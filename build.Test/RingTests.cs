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
    public class RingTests
    {
        private Ring instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Ring();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Ring
        /// </summary>
        [Test]
        public void RingInstanceTest()
        {
            Assert.IsInstanceOf<Ring> (instance, "instance is a Ring");
        }

        
        /// <summary>
        /// Test the property 'ExpansionCriteria' 
        /// </summary>
        [Test]
        public void ExpansionCriteriaTest()
        {
            // TODO: unit test for the property 'ExpansionCriteria' 
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
