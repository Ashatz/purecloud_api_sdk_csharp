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
    public class AttributeValueTests
    {
        private AttributeValue instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AttributeValue();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AttributeValue
        /// </summary>
        [Test]
        public void AttributeValueInstanceTest()
        {
            Assert.IsInstanceOf<AttributeValue> (instance, "instance is a AttributeValue");
        }

        
        /// <summary>
        /// Test the property 'S' 
        /// </summary>
        [Test]
        public void STest()
        {
            // TODO: unit test for the property 'S' 
        }
        
        /// <summary>
        /// Test the property 'N' 
        /// </summary>
        [Test]
        public void NTest()
        {
            // TODO: unit test for the property 'N' 
        }
        
        /// <summary>
        /// Test the property 'B' 
        /// </summary>
        [Test]
        public void BTest()
        {
            // TODO: unit test for the property 'B' 
        }
        
        /// <summary>
        /// Test the property 'M' 
        /// </summary>
        [Test]
        public void MTest()
        {
            // TODO: unit test for the property 'M' 
        }
        
        /// <summary>
        /// Test the property 'L' 
        /// </summary>
        [Test]
        public void LTest()
        {
            // TODO: unit test for the property 'L' 
        }
        
        /// <summary>
        /// Test the property 'Ss' 
        /// </summary>
        [Test]
        public void SsTest()
        {
            // TODO: unit test for the property 'Ss' 
        }
        
        /// <summary>
        /// Test the property 'Ns' 
        /// </summary>
        [Test]
        public void NsTest()
        {
            // TODO: unit test for the property 'Ns' 
        }
        
        /// <summary>
        /// Test the property 'Bs' 
        /// </summary>
        [Test]
        public void BsTest()
        {
            // TODO: unit test for the property 'Bs' 
        }
        
        /// <summary>
        /// Test the property 'Null' 
        /// </summary>
        [Test]
        public void NullTest()
        {
            // TODO: unit test for the property 'Null' 
        }
        
        /// <summary>
        /// Test the property 'Bool' 
        /// </summary>
        [Test]
        public void BoolTest()
        {
            // TODO: unit test for the property 'Bool' 
        }
        

    }

}
