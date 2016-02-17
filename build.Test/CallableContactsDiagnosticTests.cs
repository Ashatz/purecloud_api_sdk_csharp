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
    public class CallableContactsDiagnosticTests
    {
        private CallableContactsDiagnostic instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CallableContactsDiagnostic();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CallableContactsDiagnostic
        /// </summary>
        [Test]
        public void CallableContactsDiagnosticInstanceTest()
        {
            Assert.IsInstanceOf<CallableContactsDiagnostic> (instance, "instance is a CallableContactsDiagnostic");
        }

        
        /// <summary>
        /// Test the property 'DncLists' 
        /// </summary>
        [Test]
        public void DncListsTest()
        {
            // TODO: unit test for the property 'DncLists' 
        }
        
        /// <summary>
        /// Test the property 'CallableTimeSet' 
        /// </summary>
        [Test]
        public void CallableTimeSetTest()
        {
            // TODO: unit test for the property 'CallableTimeSet' 
        }
        
        /// <summary>
        /// Test the property 'RuleSets' 
        /// </summary>
        [Test]
        public void RuleSetsTest()
        {
            // TODO: unit test for the property 'RuleSets' 
        }
        

    }

}
