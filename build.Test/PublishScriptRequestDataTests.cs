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
    public class PublishScriptRequestDataTests
    {
        private PublishScriptRequestData instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PublishScriptRequestData();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of PublishScriptRequestData
        /// </summary>
        [Test]
        public void PublishScriptRequestDataInstanceTest()
        {
            Assert.IsInstanceOf<PublishScriptRequestData> (instance, "instance is a PublishScriptRequestData");
        }

        
        /// <summary>
        /// Test the property 'ScriptId' 
        /// </summary>
        [Test]
        public void ScriptIdTest()
        {
            // TODO: unit test for the property 'ScriptId' 
        }
        
        /// <summary>
        /// Test the property 'VersionId' 
        /// </summary>
        [Test]
        public void VersionIdTest()
        {
            // TODO: unit test for the property 'VersionId' 
        }
        

    }

}
