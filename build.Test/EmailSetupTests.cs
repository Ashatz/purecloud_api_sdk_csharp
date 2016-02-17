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
    public class EmailSetupTests
    {
        private EmailSetup instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EmailSetup();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of EmailSetup
        /// </summary>
        [Test]
        public void EmailSetupInstanceTest()
        {
            Assert.IsInstanceOf<EmailSetup> (instance, "instance is a EmailSetup");
        }

        
        /// <summary>
        /// Test the property 'RootDomain' 
        /// </summary>
        [Test]
        public void RootDomainTest()
        {
            // TODO: unit test for the property 'RootDomain' 
        }
        

    }

}
