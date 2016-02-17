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
    public class GreetingsApiTests
    {
        private GreetingsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new GreetingsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GreetingsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<GreetingsApi> (instance, "instance is a GreetingsApi");
        }

        
        /// <summary>
        /// Test GetGreetings
        /// </summary>
        [Test]
        public void GetGreetingsTest()
        {
            // TODO: add unit test for the method 'GetGreetings'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetGreetings(pageSize, pageNumber);
            Assert.IsInstanceOf<DomainEntityListing> (response, "response is DomainEntityListing"); 
        }
        
        /// <summary>
        /// Test PostGreetings
        /// </summary>
        [Test]
        public void PostGreetingsTest()
        {
            // TODO: add unit test for the method 'PostGreetings'
            Greeting body = null; // TODO: replace null with proper value
            
            var response = instance.PostGreetings(body);
            Assert.IsInstanceOf<DefaultGreetingList> (response, "response is DefaultGreetingList"); 
        }
        
        /// <summary>
        /// Test GetDefaults
        /// </summary>
        [Test]
        public void GetDefaultsTest()
        {
            // TODO: add unit test for the method 'GetDefaults'
            
            var response = instance.GetDefaults();
            Assert.IsInstanceOf<DefaultGreetingList> (response, "response is DefaultGreetingList"); 
        }
        
        /// <summary>
        /// Test PutDefaults
        /// </summary>
        [Test]
        public void PutDefaultsTest()
        {
            // TODO: add unit test for the method 'PutDefaults'
            DefaultGreetingList body = null; // TODO: replace null with proper value
            
            var response = instance.PutDefaults(body);
            Assert.IsInstanceOf<DefaultGreetingList> (response, "response is DefaultGreetingList"); 
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
            string greetingId = null; // TODO: replace null with proper value
            
            var response = instance.Get(greetingId);
            Assert.IsInstanceOf<Greeting> (response, "response is Greeting"); 
        }
        
        /// <summary>
        /// Test Put
        /// </summary>
        [Test]
        public void PutTest()
        {
            // TODO: add unit test for the method 'Put'
            string greetingId = null; // TODO: replace null with proper value
            Greeting body = null; // TODO: replace null with proper value
            
            var response = instance.Put(greetingId, body);
            Assert.IsInstanceOf<Greeting> (response, "response is Greeting"); 
        }
        
        /// <summary>
        /// Test Delete
        /// </summary>
        [Test]
        public void DeleteTest()
        {
            // TODO: add unit test for the method 'Delete'
            string greetingId = null; // TODO: replace null with proper value
            
            var response = instance.Delete(greetingId);
            Assert.IsInstanceOf<Greeting> (response, "response is Greeting"); 
        }
        
        /// <summary>
        /// Test GetMedia
        /// </summary>
        [Test]
        public void GetMediaTest()
        {
            // TODO: add unit test for the method 'GetMedia'
            string greetingId = null; // TODO: replace null with proper value
            string formatId = null; // TODO: replace null with proper value
            
            var response = instance.GetMedia(greetingId, formatId);
            Assert.IsInstanceOf<GreetingMediaInfo> (response, "response is GreetingMediaInfo"); 
        }
        
        /// <summary>
        /// Test GetUserGreetings
        /// </summary>
        [Test]
        public void GetUserGreetingsTest()
        {
            // TODO: add unit test for the method 'GetUserGreetings'
            string userId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            
            var response = instance.GetUserGreetings(userId, pageSize, pageNumber);
            Assert.IsInstanceOf<DomainEntityListing> (response, "response is DomainEntityListing"); 
        }
        
        /// <summary>
        /// Test PostUserGreetings
        /// </summary>
        [Test]
        public void PostUserGreetingsTest()
        {
            // TODO: add unit test for the method 'PostUserGreetings'
            string userId = null; // TODO: replace null with proper value
            Greeting body = null; // TODO: replace null with proper value
            
            var response = instance.PostUserGreetings(userId, body);
            Assert.IsInstanceOf<Greeting> (response, "response is Greeting"); 
        }
        
        /// <summary>
        /// Test GetUserGreetingsDefaults
        /// </summary>
        [Test]
        public void GetUserGreetingsDefaultsTest()
        {
            // TODO: add unit test for the method 'GetUserGreetingsDefaults'
            string userId = null; // TODO: replace null with proper value
            
            var response = instance.GetUserGreetingsDefaults(userId);
            Assert.IsInstanceOf<DefaultGreetingList> (response, "response is DefaultGreetingList"); 
        }
        
        /// <summary>
        /// Test PutUserGreetingsDefaults
        /// </summary>
        [Test]
        public void PutUserGreetingsDefaultsTest()
        {
            // TODO: add unit test for the method 'PutUserGreetingsDefaults'
            string userId = null; // TODO: replace null with proper value
            DefaultGreetingList body = null; // TODO: replace null with proper value
            
            var response = instance.PutUserGreetingsDefaults(userId, body);
            Assert.IsInstanceOf<DefaultGreetingList> (response, "response is DefaultGreetingList"); 
        }
        
    }

}
