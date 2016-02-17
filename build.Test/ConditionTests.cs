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
    public class ConditionTests
    {
        private Condition instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Condition();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Condition
        /// </summary>
        [Test]
        public void ConditionInstanceTest()
        {
            Assert.IsInstanceOf<Condition> (instance, "instance is a Condition");
        }

        
        /// <summary>
        /// Test the property 'Type' 
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type' 
        }
        
        /// <summary>
        /// Test the property 'Inverted' 
        /// </summary>
        [Test]
        public void InvertedTest()
        {
            // TODO: unit test for the property 'Inverted' 
        }
        
        /// <summary>
        /// Test the property 'AttributeName' 
        /// </summary>
        [Test]
        public void AttributeNameTest()
        {
            // TODO: unit test for the property 'AttributeName' 
        }
        
        /// <summary>
        /// Test the property 'Value' 
        /// </summary>
        [Test]
        public void ValueTest()
        {
            // TODO: unit test for the property 'Value' 
        }
        
        /// <summary>
        /// Test the property 'ValueType' 
        /// </summary>
        [Test]
        public void ValueTypeTest()
        {
            // TODO: unit test for the property 'ValueType' 
        }
        
        /// <summary>
        /// Test the property 'Operator' 
        /// </summary>
        [Test]
        public void OperatorTest()
        {
            // TODO: unit test for the property 'Operator' 
        }
        
        /// <summary>
        /// Test the property 'Codes' 
        /// </summary>
        [Test]
        public void CodesTest()
        {
            // TODO: unit test for the property 'Codes' 
        }
        

    }

}
