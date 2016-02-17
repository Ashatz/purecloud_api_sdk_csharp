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
    public class DeleteRetentionTests
    {
        private DeleteRetention instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new DeleteRetention();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of DeleteRetention
        /// </summary>
        [Test]
        public void DeleteRetentionInstanceTest()
        {
            Assert.IsInstanceOf<DeleteRetention> (instance, "instance is a DeleteRetention");
        }

        
        /// <summary>
        /// Test the property 'Days' 
        /// </summary>
        [Test]
        public void DaysTest()
        {
            // TODO: unit test for the property 'Days' 
        }
        

    }

}
