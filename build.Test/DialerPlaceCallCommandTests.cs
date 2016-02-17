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
    public class DialerPlaceCallCommandTests
    {
        private DialerPlaceCallCommand instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DialerPlaceCallCommand();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DialerPlaceCallCommand
        /// </summary>
        [Test]
        public void DialerPlaceCallCommandInstanceTest()
        {
            Assert.IsInstanceOf<DialerPlaceCallCommand> (instance, "instance is a DialerPlaceCallCommand");
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
        /// Test the property 'PhoneNumber' 
        /// </summary>
        [Test]
        public void PhoneNumberTest()
        {
            // TODO: unit test for the property 'PhoneNumber' 
        }
        

    }

}
