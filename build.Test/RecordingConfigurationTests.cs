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
    public class RecordingConfigurationTests
    {
        private RecordingConfiguration instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new RecordingConfiguration();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of RecordingConfiguration
        /// </summary>
        [Test]
        public void RecordingConfigurationInstanceTest()
        {
            Assert.IsInstanceOf<RecordingConfiguration> (instance, "instance is a RecordingConfiguration");
        }

        
        /// <summary>
        /// Test the property 'MaxSimultaneousStreams' 
        /// </summary>
        [Test]
        public void MaxSimultaneousStreamsTest()
        {
            // TODO: unit test for the property 'MaxSimultaneousStreams' 
        }
        

    }

}
