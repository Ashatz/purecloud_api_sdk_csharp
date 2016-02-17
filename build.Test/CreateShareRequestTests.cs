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
    public class CreateShareRequestTests
    {
        private CreateShareRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CreateShareRequest();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CreateShareRequest
        /// </summary>
        [Test]
        public void CreateShareRequestInstanceTest()
        {
            Assert.IsInstanceOf<CreateShareRequest> (instance, "instance is a CreateShareRequest");
        }

        
        /// <summary>
        /// Test the property 'SharedEntityType' 
        /// </summary>
        [Test]
        public void SharedEntityTypeTest()
        {
            // TODO: unit test for the property 'SharedEntityType' 
        }
        
        /// <summary>
        /// Test the property 'SharedEntity' 
        /// </summary>
        [Test]
        public void SharedEntityTest()
        {
            // TODO: unit test for the property 'SharedEntity' 
        }
        
        /// <summary>
        /// Test the property 'MemberType' 
        /// </summary>
        [Test]
        public void MemberTypeTest()
        {
            // TODO: unit test for the property 'MemberType' 
        }
        
        /// <summary>
        /// Test the property 'Member' 
        /// </summary>
        [Test]
        public void MemberTest()
        {
            // TODO: unit test for the property 'Member' 
        }
        
        /// <summary>
        /// Test the property 'Members' 
        /// </summary>
        [Test]
        public void MembersTest()
        {
            // TODO: unit test for the property 'Members' 
        }
        

    }

}
