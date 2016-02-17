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
    public class GreetingAudioFileTests
    {
        private GreetingAudioFile instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GreetingAudioFile();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of GreetingAudioFile
        /// </summary>
        [Test]
        public void GreetingAudioFileInstanceTest()
        {
            Assert.IsInstanceOf<GreetingAudioFile> (instance, "instance is a GreetingAudioFile");
        }

        
        /// <summary>
        /// Test the property 'DurationMilliseconds' 
        /// </summary>
        [Test]
        public void DurationMillisecondsTest()
        {
            // TODO: unit test for the property 'DurationMilliseconds' 
        }
        
        /// <summary>
        /// Test the property 'SizeBytes' 
        /// </summary>
        [Test]
        public void SizeBytesTest()
        {
            // TODO: unit test for the property 'SizeBytes' 
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
