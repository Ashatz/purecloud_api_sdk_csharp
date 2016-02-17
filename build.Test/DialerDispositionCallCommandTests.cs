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
    public class DialerDispositionCallCommandTests
    {
        private DialerDispositionCallCommand instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DialerDispositionCallCommand();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DialerDispositionCallCommand
        /// </summary>
        [Test]
        public void DialerDispositionCallCommandInstanceTest()
        {
            Assert.IsInstanceOf<DialerDispositionCallCommand> (instance, "instance is a DialerDispositionCallCommand");
        }

        
        /// <summary>
        /// Test the property 'CallId' 
        /// </summary>
        [Test]
        public void CallIdTest()
        {
            // TODO: unit test for the property 'CallId' 
        }
        
        /// <summary>
        /// Test the property 'WrapupCodeId' 
        /// </summary>
        [Test]
        public void WrapupCodeIdTest()
        {
            // TODO: unit test for the property 'WrapupCodeId' 
        }
        
        /// <summary>
        /// Test the property 'Contact' 
        /// </summary>
        [Test]
        public void ContactTest()
        {
            // TODO: unit test for the property 'Contact' 
        }
        

    }

}
