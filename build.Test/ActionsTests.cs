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
    public class ActionsTests
    {
        private Actions instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Actions();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Actions
        /// </summary>
        [Test]
        public void ActionsInstanceTest()
        {
            Assert.IsInstanceOf<Actions> (instance, "instance is a Actions");
        }

        
        /// <summary>
        /// Test the property 'SkillsToRemove' 
        /// </summary>
        [Test]
        public void SkillsToRemoveTest()
        {
            // TODO: unit test for the property 'SkillsToRemove' 
        }
        

    }

}
