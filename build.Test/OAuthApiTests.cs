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
        /// Test GetIdentityproviders
        /// </summary>
        [Test]
        public void GetIdentityprovidersTest()
        {
            // TODO: add unit test for the method 'GetIdentityproviders'
            
            var response = instance.GetIdentityproviders();
            Assert.IsInstanceOf<OAuthProviderEntityListing> (response, "response is OAuthProviderEntityListing"); 
        }
        
        /// <summary>
        /// Test GetIdentityprovidersOkta
        /// </summary>
        [Test]
        public void GetIdentityprovidersOktaTest()
        {
            // TODO: add unit test for the method 'GetIdentityprovidersOkta'
            
            var response = instance.GetIdentityprovidersOkta();
            Assert.IsInstanceOf<Okta> (response, "response is Okta"); 
        }
        
        /// <summary>
        /// Test PutIdentityprovidersOkta
        /// </summary>
        [Test]
        public void PutIdentityprovidersOktaTest()
        {
            // TODO: add unit test for the method 'PutIdentityprovidersOkta'
            Okta body = null; // TODO: replace null with proper value
            
            instance.PutIdentityprovidersOkta(body);
             
        }
        
        /// <summary>
        /// Test DeleteIdentityprovidersOkta
        /// </summary>
        [Test]
        public void DeleteIdentityprovidersOktaTest()
        {
            // TODO: add unit test for the method 'DeleteIdentityprovidersOkta'
            
            instance.DeleteIdentityprovidersOkta();
             
        }
        
        /// <summary>
        /// Test GetIdentityprovidersOnelogin
        /// </summary>
        [Test]
        public void GetIdentityprovidersOneloginTest()
        {
            // TODO: add unit test for the method 'GetIdentityprovidersOnelogin'
            
            var response = instance.GetIdentityprovidersOnelogin();
            Assert.IsInstanceOf<OneLogin> (response, "response is OneLogin"); 
        }
        
        /// <summary>
        /// Test PutIdentityprovidersOnelogin
        /// </summary>
        [Test]
        public void PutIdentityprovidersOneloginTest()
        {
            // TODO: add unit test for the method 'PutIdentityprovidersOnelogin'
            OneLogin body = null; // TODO: replace null with proper value
            
            instance.PutIdentityprovidersOnelogin(body);
             
        }
        
        /// <summary>
        /// Test DeleteIdentityprovidersOnelogin
        /// </summary>
        [Test]
        public void DeleteIdentityprovidersOneloginTest()
        {
            // TODO: add unit test for the method 'DeleteIdentityprovidersOnelogin'
            
            instance.DeleteIdentityprovidersOnelogin();
             
        }
        
        /// <summary>
        /// Test GetIdentityprovidersPurecloud
        /// </summary>
        [Test]
        public void GetIdentityprovidersPurecloudTest()
        {
            // TODO: add unit test for the method 'GetIdentityprovidersPurecloud'
            
            var response = instance.GetIdentityprovidersPurecloud();
            Assert.IsInstanceOf<PureCloud> (response, "response is PureCloud"); 
        }
        
        /// <summary>
        /// Test PutIdentityprovidersPurecloud
        /// </summary>
        [Test]
        public void PutIdentityprovidersPurecloudTest()
        {
            // TODO: add unit test for the method 'PutIdentityprovidersPurecloud'
            PureCloud body = null; // TODO: replace null with proper value
            
            instance.PutIdentityprovidersPurecloud(body);
             
        }
        
        /// <summary>
        /// Test DeleteIdentityprovidersPurecloud
        /// </summary>
        [Test]
        public void DeleteIdentityprovidersPurecloudTest()
        {
            // TODO: add unit test for the method 'DeleteIdentityprovidersPurecloud'
            
            instance.DeleteIdentityprovidersPurecloud();
             
        }
        
        /// <summary>
        /// Test GetIdentityprovidersSalesforce
        /// </summary>
        [Test]
        public void GetIdentityprovidersSalesforceTest()
        {
            // TODO: add unit test for the method 'GetIdentityprovidersSalesforce'
            
            var response = instance.GetIdentityprovidersSalesforce();
            Assert.IsInstanceOf<Salesforce> (response, "response is Salesforce"); 
        }
        
        /// <summary>
        /// Test PutIdentityprovidersSalesforce
        /// </summary>
        [Test]
        public void PutIdentityprovidersSalesforceTest()
        {
            // TODO: add unit test for the method 'PutIdentityprovidersSalesforce'
            Salesforce body = null; // TODO: replace null with proper value
            
            instance.PutIdentityprovidersSalesforce(body);
             
        }
        
        /// <summary>
        /// Test DeleteIdentityprovidersSalesforce
        /// </summary>
        [Test]
        public void DeleteIdentityprovidersSalesforceTest()
        {
            // TODO: add unit test for the method 'DeleteIdentityprovidersSalesforce'
            
            instance.DeleteIdentityprovidersSalesforce();
             
        }
        
        /// <summary>
        /// Test GetIdentityprovider
        /// </summary>
        [Test]
        public void GetIdentityproviderTest()
        {
            // TODO: add unit test for the method 'GetIdentityprovider'
            
            var response = instance.GetIdentityprovider();
            Assert.IsInstanceOf<OAuthProvider> (response, "response is OAuthProvider"); 
        }
        
        /// <summary>
        /// Test PutIdentityprovider
        /// </summary>
        [Test]
        public void PutIdentityproviderTest()
        {
            // TODO: add unit test for the method 'PutIdentityprovider'
            OAuthProvider body = null; // TODO: replace null with proper value
            
            instance.PutIdentityprovider(body);
             
        }
        
        /// <summary>
        /// Test DeleteIdentityprovider
        /// </summary>
        [Test]
        public void DeleteIdentityproviderTest()
        {
            // TODO: add unit test for the method 'DeleteIdentityprovider'
            
            instance.DeleteIdentityprovider();
             
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
        /// Test GetClient
        /// </summary>
        [Test]
        public void GetClientTest()
        {
            // TODO: add unit test for the method 'GetClient'
            string clientId = null; // TODO: replace null with proper value
            
            var response = instance.GetClient(clientId);
            Assert.IsInstanceOf<OAuthClient> (response, "response is OAuthClient"); 
        }
        
        /// <summary>
        /// Test PutClient
        /// </summary>
        [Test]
        public void PutClientTest()
        {
            // TODO: add unit test for the method 'PutClient'
            string clientId = null; // TODO: replace null with proper value
            OAuthClient body = null; // TODO: replace null with proper value
            
            var response = instance.PutClient(clientId, body);
            Assert.IsInstanceOf<OAuthClient> (response, "response is OAuthClient"); 
        }
        
        /// <summary>
        /// Test DeleteClient
        /// </summary>
        [Test]
        public void DeleteClientTest()
        {
            // TODO: add unit test for the method 'DeleteClient'
            string clientId = null; // TODO: replace null with proper value
            
            instance.DeleteClient(clientId);
             
        }
        
        /// <summary>
        /// Test PostClientSecret
        /// </summary>
        [Test]
        public void PostClientSecretTest()
        {
            // TODO: add unit test for the method 'PostClientSecret'
            string clientId = null; // TODO: replace null with proper value
            
            instance.PostClientSecret(clientId);
             
        }
        
    }

}
