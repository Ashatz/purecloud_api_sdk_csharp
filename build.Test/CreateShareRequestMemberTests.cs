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
    public class CreateShareRequestMemberTests
    {
        private CreateShareRequestMember instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CreateShareRequestMember();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CreateShareRequestMember
        /// </summary>
        [Test]
        public void CreateShareRequestMemberInstanceTest()
        {
            Assert.IsInstanceOf<CreateShareRequestMember> (instance, "instance is a CreateShareRequestMember");
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
        

    }

}
