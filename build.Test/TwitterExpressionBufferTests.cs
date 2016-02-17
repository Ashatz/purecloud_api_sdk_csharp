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
    public class TwitterExpressionBufferTests
    {
        private TwitterExpressionBuffer instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TwitterExpressionBuffer();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TwitterExpressionBuffer
        /// </summary>
        [Test]
        public void TwitterExpressionBufferInstanceTest()
        {
            Assert.IsInstanceOf<TwitterExpressionBuffer> (instance, "instance is a TwitterExpressionBuffer");
        }

        
        /// <summary>
        /// Test the property 'BufferContent' 
        /// </summary>
        [Test]
        public void BufferContentTest()
        {
            // TODO: unit test for the property 'BufferContent' 
        }
        

    }

}
