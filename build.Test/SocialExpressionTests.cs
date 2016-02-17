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
    public class SocialExpressionTests
    {
        private SocialExpression instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SocialExpression();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of SocialExpression
        /// </summary>
        [Test]
        public void SocialExpressionInstanceTest()
        {
            Assert.IsInstanceOf<SocialExpression> (instance, "instance is a SocialExpression");
        }

        
        /// <summary>
        /// Test the property 'State' 
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO: unit test for the property 'State' 
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
        /// Test the property 'SocialMediaId' 
        /// </summary>
        [Test]
        public void SocialMediaIdTest()
        {
            // TODO: unit test for the property 'SocialMediaId' 
        }
        
        /// <summary>
        /// Test the property 'SocialMediaHub' 
        /// </summary>
        [Test]
        public void SocialMediaHubTest()
        {
            // TODO: unit test for the property 'SocialMediaHub' 
        }
        
        /// <summary>
        /// Test the property 'PreviewText' 
        /// </summary>
        [Test]
        public void PreviewTextTest()
        {
            // TODO: unit test for the property 'PreviewText' 
        }
        
        /// <summary>
        /// Test the property 'RecordingId' 
        /// </summary>
        [Test]
        public void RecordingIdTest()
        {
            // TODO: unit test for the property 'RecordingId' 
        }
        
        /// <summary>
        /// Test the property 'Segments' 
        /// </summary>
        [Test]
        public void SegmentsTest()
        {
            // TODO: unit test for the property 'Segments' 
        }
        
        /// <summary>
        /// Test the property 'Held' 
        /// </summary>
        [Test]
        public void HeldTest()
        {
            // TODO: unit test for the property 'Held' 
        }
        
        /// <summary>
        /// Test the property 'DisconnectType' 
        /// </summary>
        [Test]
        public void DisconnectTypeTest()
        {
            // TODO: unit test for the property 'DisconnectType' 
        }
        
        /// <summary>
        /// Test the property 'StartHoldTime' 
        /// </summary>
        [Test]
        public void StartHoldTimeTest()
        {
            // TODO: unit test for the property 'StartHoldTime' 
        }
        

    }

}
