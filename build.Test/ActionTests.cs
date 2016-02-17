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
    public class ActionTests
    {
        private Action instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Action();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Action
        /// </summary>
        [Test]
        public void ActionInstanceTest()
        {
            Assert.IsInstanceOf<Action> (instance, "instance is a Action");
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
        /// Test the property 'ActionTypeName' 
        /// </summary>
        [Test]
        public void ActionTypeNameTest()
        {
            // TODO: unit test for the property 'ActionTypeName' 
        }
        
        /// <summary>
        /// Test the property 'UpdateOption' 
        /// </summary>
        [Test]
        public void UpdateOptionTest()
        {
            // TODO: unit test for the property 'UpdateOption' 
        }
        
        /// <summary>
        /// Test the property 'Properties' 
        /// </summary>
        [Test]
        public void PropertiesTest()
        {
            // TODO: unit test for the property 'Properties' 
        }
        

    }

}
