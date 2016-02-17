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
    public class WorkspaceMemberTests
    {
        private WorkspaceMember instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkspaceMember();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of WorkspaceMember
        /// </summary>
        [Test]
        public void WorkspaceMemberInstanceTest()
        {
            Assert.IsInstanceOf<WorkspaceMember> (instance, "instance is a WorkspaceMember");
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
        /// Test the property 'Workspace' 
        /// </summary>
        [Test]
        public void WorkspaceTest()
        {
            // TODO: unit test for the property 'Workspace' 
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
        /// Test the property 'User' 
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User' 
        }
        
        /// <summary>
        /// Test the property 'Group' 
        /// </summary>
        [Test]
        public void GroupTest()
        {
            // TODO: unit test for the property 'Group' 
        }
        
        /// <summary>
        /// Test the property 'SecurityProfile' 
        /// </summary>
        [Test]
        public void SecurityProfileTest()
        {
            // TODO: unit test for the property 'SecurityProfile' 
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
