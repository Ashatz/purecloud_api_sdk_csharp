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
    public class AcwSettingsTests
    {
        private AcwSettings instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AcwSettings();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AcwSettings
        /// </summary>
        [Test]
        public void AcwSettingsInstanceTest()
        {
            Assert.IsInstanceOf<AcwSettings> (instance, "instance is a AcwSettings");
        }

        
        /// <summary>
        /// Test the property 'WrapupPrompt' 
        /// </summary>
        [Test]
        public void WrapupPromptTest()
        {
            // TODO: unit test for the property 'WrapupPrompt' 
        }
        
        /// <summary>
        /// Test the property 'TimeoutMs' 
        /// </summary>
        [Test]
        public void TimeoutMsTest()
        {
            // TODO: unit test for the property 'TimeoutMs' 
        }
        

    }

}
