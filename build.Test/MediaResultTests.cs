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
    /// <summary>
    ///  Class for testing MediaResult
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MediaResultTests
    {
        private MediaResult instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new MediaResult();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of MediaResult
        /// </summary>
        [Test]
        public void MediaResultInstanceTest()
        {
            Assert.IsInstanceOf<MediaResult> (instance, "instance is a MediaResult");
        }

        
        /// <summary>
        /// Test the property 'MediaUri' 
        /// </summary>
        [Test]
        public void MediaUriTest()
        {
            // TODO: unit test for the property 'MediaUri' 
        }
        
        /// <summary>
        /// Test the property 'WaveformData' 
        /// </summary>
        [Test]
        public void WaveformDataTest()
        {
            // TODO: unit test for the property 'WaveformData' 
        }
        

    }

}
