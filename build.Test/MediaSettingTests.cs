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
    public class MediaSettingTests
    {
        private MediaSetting instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MediaSetting();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of MediaSetting
        /// </summary>
        [Test]
        public void MediaSettingInstanceTest()
        {
            Assert.IsInstanceOf<MediaSetting> (instance, "instance is a MediaSetting");
        }

        
        /// <summary>
        /// Test the property 'AlertingTimeoutSeconds' 
        /// </summary>
        [Test]
        public void AlertingTimeoutSecondsTest()
        {
            // TODO: unit test for the property 'AlertingTimeoutSeconds' 
        }
        
        /// <summary>
        /// Test the property 'ServiceLevel' 
        /// </summary>
        [Test]
        public void ServiceLevelTest()
        {
            // TODO: unit test for the property 'ServiceLevel' 
        }
        

    }

}
