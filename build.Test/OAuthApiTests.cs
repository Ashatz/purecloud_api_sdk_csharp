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
    public class OAuthApiTests
    {
        private OAuthApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new OAuthApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OAuthApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<OAuthApi> (instance, "instance is a OAuthApi");
        }

        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO: add unit test for the method 'Get'
            
            var response = instance.Get();
            Assert.IsInstanceOf<OAuthProviderEntityListing> (response, "response is OAuthProviderEntityListing"); 
        }
        
        /// <summary>
        /// Test GetOkta
        /// </summary>
        [Test]
        public void GetOktaTest()
        {
            // TODO: add unit test for the method 'GetOkta'
            
            var response = instance.GetOkta();
            Assert.IsInstanceOf<Okta> (response, "response is Okta"); 
        }
        
        /// <summary>
        /// Test PutOkta
        /// </summary>
        [Test]
        public void PutOktaTest()
        {
            // TODO: add unit test for the method 'PutOkta'
            Okta body = null; // TODO: replace null with proper value
            
            instance.PutOkta(body);
             
        }
        
        /// <summary>
        /// Test DeleteOkta
        /// </summary>
        [Test]
        public void DeleteOktaTest()
        {
            // TODO: add unit test for the method 'DeleteOkta'
            
            instance.DeleteOkta();
             
        }
        
        /// <summary>
        /// Test GetOnelogin
        /// </summary>
        [Test]
        public void GetOneloginTest()
        {
            // TODO: add unit test for the method 'GetOnelogin'
            
            var response = instance.GetOnelogin();
            Assert.IsInstanceOf<OneLogin> (response, "response is OneLogin"); 
        }
        
        /// <summary>
        /// Test PutOnelogin
        /// </summary>
        [Test]
        public void PutOneloginTest()
        {
            // TODO: add unit test for the method 'PutOnelogin'
            OneLogin body = null; // TODO: replace null with proper value
            
            instance.PutOnelogin(body);
             
        }
        
        /// <summary>
        /// Test DeleteOnelogin
        /// </summary>
        [Test]
        public void DeleteOneloginTest()
        {
            // TODO: add unit test for the method 'DeleteOnelogin'
            
            instance.DeleteOnelogin();
             
        }
        
        /// <summary>
        /// Test GetPurecloud
        /// </summary>
        [Test]
        public void GetPurecloudTest()
        {
            // TODO: add unit test for the method 'GetPurecloud'
            
            var response = instance.GetPurecloud();
            Assert.IsInstanceOf<PureCloud> (response, "response is PureCloud"); 
        }
        
        /// <summary>
        /// Test PutPurecloud
        /// </summary>
        [Test]
        public void PutPurecloudTest()
        {
            // TODO: add unit test for the method 'PutPurecloud'
            PureCloud body = null; // TODO: replace null with proper value
            
            instance.PutPurecloud(body);
             
        }
        
        /// <summary>
        /// Test DeletePurecloud
        /// </summary>
        [Test]
        public void DeletePurecloudTest()
        {
            // TODO: add unit test for the method 'DeletePurecloud'
            
            instance.DeletePurecloud();
             
        }
        
        /// <summary>
        /// Test GetSalesforce
        /// </summary>
        [Test]
        public void GetSalesforceTest()
        {
            // TODO: add unit test for the method 'GetSalesforce'
            
            var response = instance.GetSalesforce();
            Assert.IsInstanceOf<Salesforce> (response, "response is Salesforce"); 
        }
        
        /// <summary>
        /// Test PutSalesforce
        /// </summary>
        [Test]
        public void PutSalesforceTest()
        {
            // TODO: add unit test for the method 'PutSalesforce'
            Salesforce body = null; // TODO: replace null with proper value
            
            instance.PutSalesforce(body);
             
        }
        
        /// <summary>
        /// Test DeleteSalesforce
        /// </summary>
        [Test]
        public void DeleteSalesforceTest()
        {
            // TODO: add unit test for the method 'DeleteSalesforce'
            
            instance.DeleteSalesforce();
             
        }
        
        /// <summary>
        /// Test GetProviderId
        /// </summary>
        [Test]
        public void GetProviderIdTest()
        {
            // TODO: add unit test for the method 'GetProviderId'
            
            var response = instance.GetProviderId();
            Assert.IsInstanceOf<OAuthProvider> (response, "response is OAuthProvider"); 
        }
        
        /// <summary>
        /// Test PutProviderId
        /// </summary>
        [Test]
        public void PutProviderIdTest()
        {
            // TODO: add unit test for the method 'PutProviderId'
            OAuthProvider body = null; // TODO: replace null with proper value
            
            instance.PutProviderId(body);
             
        }
        
        /// <summary>
        /// Test DeleteProviderId
        /// </summary>
        [Test]
        public void DeleteProviderIdTest()
        {
            // TODO: add unit test for the method 'DeleteProviderId'
            
            instance.DeleteProviderId();
             
        }
        
        /// <summary>
        /// Test GetClients
        /// </summary>
        [Test]
        public void GetClientsTest()
        {
            // TODO: add unit test for the method 'GetClients'
            
            var response = instance.GetClients();
            Assert.IsInstanceOf<OAuthClientEntityListing> (response, "response is OAuthClientEntityListing"); 
        }
        
        /// <summary>
        /// Test PostClients
        /// </summary>
        [Test]
        public void PostClientsTest()
        {
            // TODO: add unit test for the method 'PostClients'
            OAuthClient body = null; // TODO: replace null with proper value
            
            var response = instance.PostClients(body);
            Assert.IsInstanceOf<OAuthClient> (response, "response is OAuthClient"); 
        }
        
        /// <summary>
        /// Test GetClientsClientId
        /// </summary>
        [Test]
        public void GetClientsClientIdTest()
        {
            // TODO: add unit test for the method 'GetClientsClientId'
            string clientId = null; // TODO: replace null with proper value
            
            var response = instance.GetClientsClientId(clientId);
            Assert.IsInstanceOf<OAuthClient> (response, "response is OAuthClient"); 
        }
        
        /// <summary>
        /// Test PutClientsClientId
        /// </summary>
        [Test]
        public void PutClientsClientIdTest()
        {
            // TODO: add unit test for the method 'PutClientsClientId'
            string clientId = null; // TODO: replace null with proper value
            OAuthClient body = null; // TODO: replace null with proper value
            
            var response = instance.PutClientsClientId(clientId, body);
            Assert.IsInstanceOf<OAuthClient> (response, "response is OAuthClient"); 
        }
        
        /// <summary>
        /// Test DeleteClientsClientId
        /// </summary>
        [Test]
        public void DeleteClientsClientIdTest()
        {
            // TODO: add unit test for the method 'DeleteClientsClientId'
            string clientId = null; // TODO: replace null with proper value
            
            instance.DeleteClientsClientId(clientId);
             
        }
        
        /// <summary>
        /// Test PostClientsClientIdSecret
        /// </summary>
        [Test]
        public void PostClientsClientIdSecretTest()
        {
            // TODO: add unit test for the method 'PostClientsClientIdSecret'
            string clientId = null; // TODO: replace null with proper value
            
            instance.PostClientsClientIdSecret(clientId);
             
        }
        
    }

}
