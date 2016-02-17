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
    public class VoiceRateUpdateTests
    {
        private VoiceRateUpdate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VoiceRateUpdate();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of VoiceRateUpdate
        /// </summary>
        [Test]
        public void VoiceRateUpdateInstanceTest()
        {
            Assert.IsInstanceOf<VoiceRateUpdate> (instance, "instance is a VoiceRateUpdate");
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
        /// Test the property 'InboundTollFree' 
        /// </summary>
        [Test]
        public void InboundTollFreeTest()
        {
            // TODO: unit test for the property 'InboundTollFree' 
        }
        
        /// <summary>
        /// Test the property 'Extended' 
        /// </summary>
        [Test]
        public void ExtendedTest()
        {
            // TODO: unit test for the property 'Extended' 
        }
        
        /// <summary>
        /// Test the property 'InboundTolled' 
        /// </summary>
        [Test]
        public void InboundTolledTest()
        {
            // TODO: unit test for the property 'InboundTolled' 
        }
        
        /// <summary>
        /// Test the property 'OutboundLocal' 
        /// </summary>
        [Test]
        public void OutboundLocalTest()
        {
            // TODO: unit test for the property 'OutboundLocal' 
        }
        
        /// <summary>
        /// Test the property 'OutboundIntraState' 
        /// </summary>
        [Test]
        public void OutboundIntraStateTest()
        {
            // TODO: unit test for the property 'OutboundIntraState' 
        }
        
        /// <summary>
        /// Test the property 'OutboundInterState' 
        /// </summary>
        [Test]
        public void OutboundInterStateTest()
        {
            // TODO: unit test for the property 'OutboundInterState' 
        }
        
        /// <summary>
        /// Test the property 'OutboundInternational' 
        /// </summary>
        [Test]
        public void OutboundInternationalTest()
        {
            // TODO: unit test for the property 'OutboundInternational' 
        }
        
        /// <summary>
        /// Test the property 'AmendmentDate' 
        /// </summary>
        [Test]
        public void AmendmentDateTest()
        {
            // TODO: unit test for the property 'AmendmentDate' 
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
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}