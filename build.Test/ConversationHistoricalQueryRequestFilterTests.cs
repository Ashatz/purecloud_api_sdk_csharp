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
    public class ConversationHistoricalQueryRequestFilterTests
    {
        private ConversationHistoricalQueryRequestFilter instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConversationHistoricalQueryRequestFilter();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ConversationHistoricalQueryRequestFilter
        /// </summary>
        [Test]
        public void ConversationHistoricalQueryRequestFilterInstanceTest()
        {
            Assert.IsInstanceOf<ConversationHistoricalQueryRequestFilter> (instance, "instance is a ConversationHistoricalQueryRequestFilter");
        }

        
        /// <summary>
        /// Test the property 'Target' 
        /// </summary>
        [Test]
        public void TargetTest()
        {
            // TODO: unit test for the property 'Target' 
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
        /// Test the property 'Values' 
        /// </summary>
        [Test]
        public void ValuesTest()
        {
            // TODO: unit test for the property 'Values' 
        }
        

    }

}
