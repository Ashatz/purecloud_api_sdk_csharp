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
    public class TransformEndpointTests
    {
        private TransformEndpoint instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TransformEndpoint();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TransformEndpoint
        /// </summary>
        [Test]
        public void TransformEndpointInstanceTest()
        {
            Assert.IsInstanceOf<TransformEndpoint> (instance, "instance is a TransformEndpoint");
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
        /// Test the property 'SwaggerUrl' 
        /// </summary>
        [Test]
        public void SwaggerUrlTest()
        {
            // TODO: unit test for the property 'SwaggerUrl' 
        }
        
        /// <summary>
        /// Test the property 'Route' 
        /// </summary>
        [Test]
        public void RouteTest()
        {
            // TODO: unit test for the property 'Route' 
        }
        
        /// <summary>
        /// Test the property 'Entity' 
        /// </summary>
        [Test]
        public void EntityTest()
        {
            // TODO: unit test for the property 'Entity' 
        }
        
        /// <summary>
        /// Test the property 'ApiFunction' 
        /// </summary>
        [Test]
        public void ApiFunctionTest()
        {
            // TODO: unit test for the property 'ApiFunction' 
        }
        
        /// <summary>
        /// Test the property 'Ready' 
        /// </summary>
        [Test]
        public void ReadyTest()
        {
            // TODO: unit test for the property 'Ready' 
        }
        
        /// <summary>
        /// Test the property 'Active' 
        /// </summary>
        [Test]
        public void ActiveTest()
        {
            // TODO: unit test for the property 'Active' 
        }
        
        /// <summary>
        /// Test the property 'BatchSize' 
        /// </summary>
        [Test]
        public void BatchSizeTest()
        {
            // TODO: unit test for the property 'BatchSize' 
        }
        
        /// <summary>
        /// Test the property 'Parallelism' 
        /// </summary>
        [Test]
        public void ParallelismTest()
        {
            // TODO: unit test for the property 'Parallelism' 
        }
        
        /// <summary>
        /// Test the property 'UpdateProgressEvery' 
        /// </summary>
        [Test]
        public void UpdateProgressEveryTest()
        {
            // TODO: unit test for the property 'UpdateProgressEvery' 
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
