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
    public class ConsultTransferResponseTests
    {
        private ConsultTransferResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ConsultTransferResponse();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ConsultTransferResponse
        /// </summary>
        [Test]
        public void ConsultTransferResponseInstanceTest()
        {
            Assert.IsInstanceOf<ConsultTransferResponse> (instance, "instance is a ConsultTransferResponse");
        }

        
        /// <summary>
        /// Test the property 'DestinationParticipantId' 
        /// </summary>
        [Test]
        public void DestinationParticipantIdTest()
        {
            // TODO: unit test for the property 'DestinationParticipantId' 
        }
        

    }

}
