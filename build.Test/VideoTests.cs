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
    public class VideoTests
    {
        private Video instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Video();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Video
        /// </summary>
        [Test]
        public void VideoInstanceTest()
        {
            Assert.IsInstanceOf<Video> (instance, "instance is a Video");
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
        /// Test the property 'Context' 
        /// </summary>
        [Test]
        public void ContextTest()
        {
            // TODO: unit test for the property 'Context' 
        }
        
        /// <summary>
        /// Test the property 'AudioMuted' 
        /// </summary>
        [Test]
        public void AudioMutedTest()
        {
            // TODO: unit test for the property 'AudioMuted' 
        }
        
        /// <summary>
        /// Test the property 'VideoMuted' 
        /// </summary>
        [Test]
        public void VideoMutedTest()
        {
            // TODO: unit test for the property 'VideoMuted' 
        }
        
        /// <summary>
        /// Test the property 'SharingScreen' 
        /// </summary>
        [Test]
        public void SharingScreenTest()
        {
            // TODO: unit test for the property 'SharingScreen' 
        }
        
        /// <summary>
        /// Test the property 'PeerCount' 
        /// </summary>
        [Test]
        public void PeerCountTest()
        {
            // TODO: unit test for the property 'PeerCount' 
        }
        
        /// <summary>
        /// Test the property 'DisconnectType' 
        /// </summary>
        [Test]
        public void DisconnectTypeTest()
        {
            // TODO: unit test for the property 'DisconnectType' 
        }
        

    }

}
