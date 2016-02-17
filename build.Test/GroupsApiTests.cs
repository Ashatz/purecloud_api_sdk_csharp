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
        /// Test GetGroups
        /// </summary>
        [Test]
        public void GetGroupsTest()
        {
            // TODO: add unit test for the method 'GetGroups'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            
            var response = instance.GetGroups(pageSize, pageNumber, name);
            Assert.IsInstanceOf<GroupEntityListing> (response, "response is GroupEntityListing"); 
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
            string groupId = null; // TODO: replace null with proper value
            
            var response = instance.Get(groupId);
            Assert.IsInstanceOf<Group> (response, "response is Group"); 
        }
        
        /// <summary>
        /// Test GetMembers
        /// </summary>
        [Test]
        public void GetMembersTest()
        {
            // TODO: add unit test for the method 'GetMembers'
            string groupId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetMembers(groupId, pageSize, pageNumber);
            Assert.IsInstanceOf<UserEntityListing> (response, "response is UserEntityListing"); 
        }
        
    }

}
