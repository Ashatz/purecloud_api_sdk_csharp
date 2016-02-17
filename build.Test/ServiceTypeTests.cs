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
    public class ServiceTypeTests
    {
        private ServiceType instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ServiceType();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ServiceType
        /// </summary>
        [Test]
        public void ServiceTypeInstanceTest()
        {
            Assert.IsInstanceOf<ServiceType> (instance, "instance is a ServiceType");
        }

        
        /// <summary>
        /// Test the property 'Type' 
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type' 
        }
        
        /// <summary>
        /// Test the property 'Parameters' 
        /// </summary>
        [Test]
        public void ParametersTest()
        {
            // TODO: unit test for the property 'Parameters' 
        }
        
        /// <summary>
        /// Test the property 'Codecs' 
        /// </summary>
        [Test]
        public void CodecsTest()
        {
            // TODO: unit test for the property 'Codecs' 
        }
        
        /// <summary>
        /// Test the property 'CallingPartyId' 
        /// </summary>
        [Test]
        public void CallingPartyIdTest()
        {
            // TODO: unit test for the property 'CallingPartyId' 
        }
        
        /// <summary>
        /// Test the property 'CallHistory' 
        /// </summary>
        [Test]
        public void CallHistoryTest()
        {
            // TODO: unit test for the property 'CallHistory' 
        }
        
        /// <summary>
        /// Test the property 'Prefix' 
        /// </summary>
        [Test]
        public void PrefixTest()
        {
            // TODO: unit test for the property 'Prefix' 
        }
        

    }

}
