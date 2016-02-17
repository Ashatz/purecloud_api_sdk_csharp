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
    public class VoiceRateInternationalTests
    {
        private VoiceRateInternational instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VoiceRateInternational();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of VoiceRateInternational
        /// </summary>
        [Test]
        public void VoiceRateInternationalInstanceTest()
        {
            Assert.IsInstanceOf<VoiceRateInternational> (instance, "instance is a VoiceRateInternational");
        }

        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        
        /// <summary>
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
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
        /// Test the property 'AmendmentId' 
        /// </summary>
        [Test]
        public void AmendmentIdTest()
        {
            // TODO: unit test for the property 'AmendmentId' 
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
        /// Test the property 'EffectiveDate' 
        /// </summary>
        [Test]
        public void EffectiveDateTest()
        {
            // TODO: unit test for the property 'EffectiveDate' 
        }
        
        /// <summary>
        /// Test the property 'Rate' 
        /// </summary>
        [Test]
        public void RateTest()
        {
            // TODO: unit test for the property 'Rate' 
        }
        
        /// <summary>
        /// Test the property 'DurationMinimumSeconds' 
        /// </summary>
        [Test]
        public void DurationMinimumSecondsTest()
        {
            // TODO: unit test for the property 'DurationMinimumSeconds' 
        }
        
        /// <summary>
        /// Test the property 'DurationIncrementSeconds' 
        /// </summary>
        [Test]
        public void DurationIncrementSecondsTest()
        {
            // TODO: unit test for the property 'DurationIncrementSeconds' 
        }
        
        /// <summary>
        /// Test the property 'Origin' 
        /// </summary>
        [Test]
        public void OriginTest()
        {
            // TODO: unit test for the property 'Origin' 
        }
        
        /// <summary>
        /// Test the property 'Destination' 
        /// </summary>
        [Test]
        public void DestinationTest()
        {
            // TODO: unit test for the property 'Destination' 
        }
        
        /// <summary>
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}
