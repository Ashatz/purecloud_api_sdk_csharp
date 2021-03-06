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
    /// <summary>
    ///  Class for testing Agent
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class AgentTests
    {
        private Agent instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Agent();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Agent
        /// </summary>
        [Test]
        public void AgentInstanceTest()
        {
            Assert.IsInstanceOf<Agent> (instance, "instance is a Agent");
        }

        /// <summary>
        /// Test the property 'Stage'
        /// </summary>
        [Test]
        public void StageTest()
        {
            // TODO: unit test for the property 'Stage'
        }

    }

}
