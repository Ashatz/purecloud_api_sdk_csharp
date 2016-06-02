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
    ///  Class for testing Keyword
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class KeywordTests
    {
        private Keyword instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Keyword();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Keyword
        /// </summary>
        [Test]
        public void KeywordInstanceTest()
        {
            Assert.IsInstanceOf<Keyword> (instance, "instance is a Keyword");
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
        /// Test the property 'Phrase'
        /// </summary>
        [Test]
        public void PhraseTest()
        {
            // TODO: unit test for the property 'Phrase'
        }
        /// <summary>
        /// Test the property 'Confidence'
        /// </summary>
        [Test]
        public void ConfidenceTest()
        {
            // TODO: unit test for the property 'Confidence'
        }
        /// <summary>
        /// Test the property 'AgentScoreModifier'
        /// </summary>
        [Test]
        public void AgentScoreModifierTest()
        {
            // TODO: unit test for the property 'AgentScoreModifier'
        }
        /// <summary>
        /// Test the property 'CustomerScoreModifier'
        /// </summary>
        [Test]
        public void CustomerScoreModifierTest()
        {
            // TODO: unit test for the property 'CustomerScoreModifier'
        }
        /// <summary>
        /// Test the property 'AlternateSpellings'
        /// </summary>
        [Test]
        public void AlternateSpellingsTest()
        {
            // TODO: unit test for the property 'AlternateSpellings'
        }

    }

}
