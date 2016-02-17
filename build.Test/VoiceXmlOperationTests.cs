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
    public class VoiceXmlOperationTests
    {
        private VoiceXmlOperation instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VoiceXmlOperation();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of VoiceXmlOperation
        /// </summary>
        [Test]
        public void VoiceXmlOperationInstanceTest()
        {
            Assert.IsInstanceOf<VoiceXmlOperation> (instance, "instance is a VoiceXmlOperation");
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
        /// Test the property 'Type' 
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO: unit test for the property 'Type' 
        }
        
        /// <summary>
        /// Test the property 'Method' 
        /// </summary>
        [Test]
        public void MethodTest()
        {
            // TODO: unit test for the property 'Method' 
        }
        
        /// <summary>
        /// Test the property 'Encoding' 
        /// </summary>
        [Test]
        public void EncodingTest()
        {
            // TODO: unit test for the property 'Encoding' 
        }
        
        /// <summary>
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
        }
        
        /// <summary>
        /// Test the property 'Uri' 
        /// </summary>
        [Test]
        public void UriTest()
        {
            // TODO: unit test for the property 'Uri' 
        }
        
        /// <summary>
        /// Test the property 'Inputs' 
        /// </summary>
        [Test]
        public void InputsTest()
        {
            // TODO: unit test for the property 'Inputs' 
        }
        
        /// <summary>
        /// Test the property 'Outputs' 
        /// </summary>
        [Test]
        public void OutputsTest()
        {
            // TODO: unit test for the property 'Outputs' 
        }
        
        /// <summary>
        /// Test the property 'FetchAudio' 
        /// </summary>
        [Test]
        public void FetchAudioTest()
        {
            // TODO: unit test for the property 'FetchAudio' 
        }
        
        /// <summary>
        /// Test the property 'TimeoutMS' 
        /// </summary>
        [Test]
        public void TimeoutMSTest()
        {
            // TODO: unit test for the property 'TimeoutMS' 
        }
        
        /// <summary>
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        

    }

}
