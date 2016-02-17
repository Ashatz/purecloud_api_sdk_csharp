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
    public class GroupTests
    {
        private Group instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Group();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Group
        /// </summary>
        [Test]
        public void GroupInstanceTest()
        {
            Assert.IsInstanceOf<Group> (instance, "instance is a Group");
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
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
        }
        
        /// <summary>
        /// Test the property 'MemberCount' 
        /// </summary>
        [Test]
        public void MemberCountTest()
        {
            // TODO: unit test for the property 'MemberCount' 
        }
        
        /// <summary>
        /// Test the property 'GroupType' 
        /// </summary>
        [Test]
        public void GroupTypeTest()
        {
            // TODO: unit test for the property 'GroupType' 
        }
        
        /// <summary>
        /// Test the property 'GroupImages' 
        /// </summary>
        [Test]
        public void GroupImagesTest()
        {
            // TODO: unit test for the property 'GroupImages' 
        }
        
        /// <summary>
        /// Test the property 'GroupState' 
        /// </summary>
        [Test]
        public void GroupStateTest()
        {
            // TODO: unit test for the property 'GroupState' 
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
