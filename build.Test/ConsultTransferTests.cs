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
    public class ConsultTransferTests
    {
        private ConsultTransfer instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConsultTransfer();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ConsultTransfer
        /// </summary>
        [Test]
        public void ConsultTransferInstanceTest()
        {
            Assert.IsInstanceOf<ConsultTransfer> (instance, "instance is a ConsultTransfer");
        }

        
        /// <summary>
        /// Test the property 'SpeakTo' 
        /// </summary>
        [Test]
        public void SpeakToTest()
        {
            // TODO: unit test for the property 'SpeakTo' 
        }
        
        /// <summary>
        /// Test the property 'Destination' 
        /// </summary>
        [Test]
        public void DestinationTest()
        {
            // TODO: unit test for the property 'Destination' 
        }
        

    }

}
