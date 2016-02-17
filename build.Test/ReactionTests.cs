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
    public class ReactionTests
    {
        private Reaction instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Reaction();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Reaction
        /// </summary>
        [Test]
        public void ReactionInstanceTest()
        {
            Assert.IsInstanceOf<Reaction> (instance, "instance is a Reaction");
        }

        
        /// <summary>
        /// Test the property 'Data' 
        /// </summary>
        [Test]
        public void DataTest()
        {
            // TODO: unit test for the property 'Data' 
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
        /// Test the property 'ReactionType' 
        /// </summary>
        [Test]
        public void ReactionTypeTest()
        {
            // TODO: unit test for the property 'ReactionType' 
        }
        

    }

}