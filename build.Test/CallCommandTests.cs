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
    public class CallCommandTests
    {
        private CallCommand instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CallCommand();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CallCommand
        /// </summary>
        [Test]
        public void CallCommandInstanceTest()
        {
            Assert.IsInstanceOf<CallCommand> (instance, "instance is a CallCommand");
        }

        
        /// <summary>
        /// Test the property 'CallNumber' 
        /// </summary>
        [Test]
        public void CallNumberTest()
        {
            // TODO: unit test for the property 'CallNumber' 
        }
        

    }

}
