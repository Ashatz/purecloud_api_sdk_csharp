using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Api;
using ININ.PureCloudApi.Model;

namespace ININ.PureCloudApi.Test
{
    [TestFixture]
    public class GroupsApiTests
    {
        private GroupsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new GroupsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<GroupsApi> (instance, "instance is a GroupsApi");
        }

        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            
            var response = instance.Get(pageSize, pageNumber, name);
            Assert.IsInstanceOf<GroupEntityListing> (response, "response is GroupEntityListing"); 
        }
        
        /// <summary>
        /// Test GetGroupId
        /// </summary>
        [Test]
        public void GetGroupIdTest()
        {
            // TODO: add unit test for the method 'GetGroupId'
            string groupId = null; // TODO: replace null with proper value
            
            var response = instance.GetGroupId(groupId);
            Assert.IsInstanceOf<Group> (response, "response is Group"); 
        }
        
        /// <summary>
        /// Test GetGroupIdMembers
        /// </summary>
        [Test]
        public void GetGroupIdMembersTest()
        {
            // TODO: add unit test for the method 'GetGroupIdMembers'
            string groupId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetGroupIdMembers(groupId, pageSize, pageNumber);
            Assert.IsInstanceOf<UserEntityListing> (response, "response is UserEntityListing"); 
        }
        
    }

}
