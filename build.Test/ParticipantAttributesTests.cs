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
    public class ParticipantAttributesTests
    {
        private ParticipantAttributes instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ParticipantAttributes();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ParticipantAttributes
        /// </summary>
        [Test]
        public void ParticipantAttributesInstanceTest()
        {
            Assert.IsInstanceOf<ParticipantAttributes> (instance, "instance is a ParticipantAttributes");
        }

        
        /// <summary>
        /// Test the property 'Attributes' 
        /// </summary>
        [Test]
        public void AttributesTest()
        {
            // TODO: unit test for the property 'Attributes' 
        }
        

    }

}
