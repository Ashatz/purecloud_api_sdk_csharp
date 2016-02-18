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
    public class RuleTests
    {
        private Rule instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Rule();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Rule
        /// </summary>
        [Test]
        public void RuleInstanceTest()
        {
            Assert.IsInstanceOf<Rule> (instance, "instance is a Rule");
        }

        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        
        /// <summary>
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }
        
        /// <summary>
        /// Test the property 'Order' 
        /// </summary>
        [Test]
        public void OrderTest()
        {
            // TODO: unit test for the property 'Order' 
        }
        
        /// <summary>
        /// Test the property 'Category' 
        /// </summary>
        [Test]
        public void CategoryTest()
        {
            // TODO: unit test for the property 'Category' 
        }
        
        /// <summary>
        /// Test the property 'Conditions' 
        /// </summary>
        [Test]
        public void ConditionsTest()
        {
            // TODO: unit test for the property 'Conditions' 
        }
        
        /// <summary>
        /// Test the property 'Actions' 
        /// </summary>
        [Test]
        public void ActionsTest()
        {
            // TODO: unit test for the property 'Actions' 
        }
        

    }

}
