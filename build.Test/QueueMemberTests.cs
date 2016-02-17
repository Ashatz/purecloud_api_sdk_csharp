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
    public class QueueMemberTests
    {
        private QueueMember instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new QueueMember();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of QueueMember
        /// </summary>
        [Test]
        public void QueueMemberInstanceTest()
        {
            Assert.IsInstanceOf<QueueMember> (instance, "instance is a QueueMember");
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
        /// Test the property 'User' 
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User' 
        }
        
        /// <summary>
        /// Test the property 'RingNumber' 
        /// </summary>
        [Test]
        public void RingNumberTest()
        {
            // TODO: unit test for the property 'RingNumber' 
        }
        
        /// <summary>
        /// Test the property 'Joined' 
        /// </summary>
        [Test]
        public void JoinedTest()
        {
            // TODO: unit test for the property 'Joined' 
        }
        
        /// <summary>
        /// Test the property 'MemberBy' 
        /// </summary>
        [Test]
        public void MemberByTest()
        {
            // TODO: unit test for the property 'MemberBy' 
        }
        
        /// <summary>
        /// Test the property 'RoutingStatus' 
        /// </summary>
        [Test]
        public void RoutingStatusTest()
        {
            // TODO: unit test for the property 'RoutingStatus' 
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