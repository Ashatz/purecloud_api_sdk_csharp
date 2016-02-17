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
    public class DomainNetworkCommandResponseTests
    {
        private DomainNetworkCommandResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DomainNetworkCommandResponse();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DomainNetworkCommandResponse
        /// </summary>
        [Test]
        public void DomainNetworkCommandResponseInstanceTest()
        {
            Assert.IsInstanceOf<DomainNetworkCommandResponse> (instance, "instance is a DomainNetworkCommandResponse");
        }

        
        /// <summary>
        /// Test the property 'CorrelationId' 
        /// </summary>
        [Test]
        public void CorrelationIdTest()
        {
            // TODO: unit test for the property 'CorrelationId' 
        }
        
        /// <summary>
        /// Test the property 'CommandName' 
        /// </summary>
        [Test]
        public void CommandNameTest()
        {
            // TODO: unit test for the property 'CommandName' 
        }
        
        /// <summary>
        /// Test the property 'Acknowledged' 
        /// </summary>
        [Test]
        public void AcknowledgedTest()
        {
            // TODO: unit test for the property 'Acknowledged' 
        }
        
        /// <summary>
        /// Test the property 'ErrorInfo' 
        /// </summary>
        [Test]
        public void ErrorInfoTest()
        {
            // TODO: unit test for the property 'ErrorInfo' 
        }
        

    }

}
