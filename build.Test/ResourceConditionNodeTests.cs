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
    public class ResourceConditionNodeTests
    {
        private ResourceConditionNode instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ResourceConditionNode();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ResourceConditionNode
        /// </summary>
        [Test]
        public void ResourceConditionNodeInstanceTest()
        {
            Assert.IsInstanceOf<ResourceConditionNode> (instance, "instance is a ResourceConditionNode");
        }

        
        /// <summary>
        /// Test the property 'VariableName' 
        /// </summary>
        [Test]
        public void VariableNameTest()
        {
            // TODO: unit test for the property 'VariableName' 
        }
        
        /// <summary>
        /// Test the property 'Conjunction' 
        /// </summary>
        [Test]
        public void ConjunctionTest()
        {
            // TODO: unit test for the property 'Conjunction' 
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
        /// Test the property 'Operands' 
        /// </summary>
        [Test]
        public void OperandsTest()
        {
            // TODO: unit test for the property 'Operands' 
        }
        
        /// <summary>
        /// Test the property 'Terms' 
        /// </summary>
        [Test]
        public void TermsTest()
        {
            // TODO: unit test for the property 'Terms' 
        }
        

    }

}
