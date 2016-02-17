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
    public class ByteBufferTests
    {
        private ByteBuffer instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ByteBuffer();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ByteBuffer
        /// </summary>
        [Test]
        public void ByteBufferInstanceTest()
        {
            Assert.IsInstanceOf<ByteBuffer> (instance, "instance is a ByteBuffer");
        }

        
        /// <summary>
        /// Test the property 'Short' 
        /// </summary>
        [Test]
        public void ShortTest()
        {
            // TODO: unit test for the property 'Short' 
        }
        
        /// <summary>
        /// Test the property 'Char' 
        /// </summary>
        [Test]
        public void CharTest()
        {
            // TODO: unit test for the property 'Char' 
        }
        
        /// <summary>
        /// Test the property 'Int' 
        /// </summary>
        [Test]
        public void IntTest()
        {
            // TODO: unit test for the property 'Int' 
        }
        
        /// <summary>
        /// Test the property 'Long' 
        /// </summary>
        [Test]
        public void LongTest()
        {
            // TODO: unit test for the property 'Long' 
        }
        
        /// <summary>
        /// Test the property 'Float' 
        /// </summary>
        [Test]
        public void FloatTest()
        {
            // TODO: unit test for the property 'Float' 
        }
        
        /// <summary>
        /// Test the property 'Double' 
        /// </summary>
        [Test]
        public void DoubleTest()
        {
            // TODO: unit test for the property 'Double' 
        }
        
        /// <summary>
        /// Test the property 'Direct' 
        /// </summary>
        [Test]
        public void DirectTest()
        {
            // TODO: unit test for the property 'Direct' 
        }
        
        /// <summary>
        /// Test the property 'ReadOnly' 
        /// </summary>
        [Test]
        public void ReadOnlyTest()
        {
            // TODO: unit test for the property 'ReadOnly' 
        }
        

    }

}
