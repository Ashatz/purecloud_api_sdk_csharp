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
    public class TraceTests
    {
        private Trace instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Trace();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Trace
        /// </summary>
        [Test]
        public void TraceInstanceTest()
        {
            Assert.IsInstanceOf<Trace> (instance, "instance is a Trace");
        }

        
        /// <summary>
        /// Test the property 'Topic' 
        /// </summary>
        [Test]
        public void TopicTest()
        {
            // TODO: unit test for the property 'Topic' 
        }
        
        /// <summary>
        /// Test the property 'Timestamp' 
        /// </summary>
        [Test]
        public void TimestampTest()
        {
            // TODO: unit test for the property 'Timestamp' 
        }
        
        /// <summary>
        /// Test the property 'Level' 
        /// </summary>
        [Test]
        public void LevelTest()
        {
            // TODO: unit test for the property 'Level' 
        }
        
        /// <summary>
        /// Test the property 'Message' 
        /// </summary>
        [Test]
        public void MessageTest()
        {
            // TODO: unit test for the property 'Message' 
        }
        
        /// <summary>
        /// Test the property 'Details' 
        /// </summary>
        [Test]
        public void DetailsTest()
        {
            // TODO: unit test for the property 'Details' 
        }
        
        /// <summary>
        /// Test the property 'TimestampString' 
        /// </summary>
        [Test]
        public void TimestampStringTest()
        {
            // TODO: unit test for the property 'TimestampString' 
        }
        
        /// <summary>
        /// Test the property 'DetailsString' 
        /// </summary>
        [Test]
        public void DetailsStringTest()
        {
            // TODO: unit test for the property 'DetailsString' 
        }
        

    }

}
