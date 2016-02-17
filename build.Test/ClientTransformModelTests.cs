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
    public class ClientTransformModelTests
    {
        private ClientTransformModel instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ClientTransformModel();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ClientTransformModel
        /// </summary>
        [Test]
        public void ClientTransformModelInstanceTest()
        {
            Assert.IsInstanceOf<ClientTransformModel> (instance, "instance is a ClientTransformModel");
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
        /// Test the property 'EndpointId' 
        /// </summary>
        [Test]
        public void EndpointIdTest()
        {
            // TODO: unit test for the property 'EndpointId' 
        }
        
        /// <summary>
        /// Test the property 'FilenameReplaces' 
        /// </summary>
        [Test]
        public void FilenameReplacesTest()
        {
            // TODO: unit test for the property 'FilenameReplaces' 
        }
        
        /// <summary>
        /// Test the property 'Tags' 
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO: unit test for the property 'Tags' 
        }
        
        /// <summary>
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }
        

    }

}
