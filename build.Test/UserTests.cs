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
    public class UserTests
    {
        private User instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new User();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of User
        /// </summary>
        [Test]
        public void UserInstanceTest()
        {
            Assert.IsInstanceOf<User> (instance, "instance is a User");
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
        /// Test the property 'Username' 
        /// </summary>
        [Test]
        public void UsernameTest()
        {
            // TODO: unit test for the property 'Username' 
        }
        
        /// <summary>
        /// Test the property 'Email' 
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO: unit test for the property 'Email' 
        }
        
        /// <summary>
        /// Test the property 'DisplayName' 
        /// </summary>
        [Test]
        public void DisplayNameTest()
        {
            // TODO: unit test for the property 'DisplayName' 
        }
        
        /// <summary>
        /// Test the property 'PhoneNumber' 
        /// </summary>
        [Test]
        public void PhoneNumberTest()
        {
            // TODO: unit test for the property 'PhoneNumber' 
        }
        
        /// <summary>
        /// Test the property 'UserImages' 
        /// </summary>
        [Test]
        public void UserImagesTest()
        {
            // TODO: unit test for the property 'UserImages' 
        }
        
        /// <summary>
        /// Test the property 'Chat' 
        /// </summary>
        [Test]
        public void ChatTest()
        {
            // TODO: unit test for the property 'Chat' 
        }
        
        /// <summary>
        /// Test the property 'Roles' 
        /// </summary>
        [Test]
        public void RolesTest()
        {
            // TODO: unit test for the property 'Roles' 
        }
        
        /// <summary>
        /// Test the property 'VoicemailEnabled' 
        /// </summary>
        [Test]
        public void VoicemailEnabledTest()
        {
            // TODO: unit test for the property 'VoicemailEnabled' 
        }
        
        /// <summary>
        /// Test the property 'Department' 
        /// </summary>
        [Test]
        public void DepartmentTest()
        {
            // TODO: unit test for the property 'Department' 
        }
        
        /// <summary>
        /// Test the property 'Title' 
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO: unit test for the property 'Title' 
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
        /// Test the property 'Password' 
        /// </summary>
        [Test]
        public void PasswordTest()
        {
            // TODO: unit test for the property 'Password' 
        }
        
        /// <summary>
        /// Test the property 'PrimaryPresence' 
        /// </summary>
        [Test]
        public void PrimaryPresenceTest()
        {
            // TODO: unit test for the property 'PrimaryPresence' 
        }
        
        /// <summary>
        /// Test the property 'Conversations' 
        /// </summary>
        [Test]
        public void ConversationsTest()
        {
            // TODO: unit test for the property 'Conversations' 
        }
        
        /// <summary>
        /// Test the property 'ConversationSummary' 
        /// </summary>
        [Test]
        public void ConversationSummaryTest()
        {
            // TODO: unit test for the property 'ConversationSummary' 
        }
        
        /// <summary>
        /// Test the property 'OutOfOffice' 
        /// </summary>
        [Test]
        public void OutOfOfficeTest()
        {
            // TODO: unit test for the property 'OutOfOffice' 
        }
        
        /// <summary>
        /// Test the property 'Geolocation' 
        /// </summary>
        [Test]
        public void GeolocationTest()
        {
            // TODO: unit test for the property 'Geolocation' 
        }
        
        /// <summary>
        /// Test the property 'Permissions' 
        /// </summary>
        [Test]
        public void PermissionsTest()
        {
            // TODO: unit test for the property 'Permissions' 
        }
        
        /// <summary>
        /// Test the property 'SelfUri' 
        /// </summary>
        [Test]
        public void SelfUriTest()
        {
            // TODO: unit test for the property 'SelfUri' 
        }
        
        /// <summary>
        /// Test the property 'RequestedStatus' 
        /// </summary>
        [Test]
        public void RequestedStatusTest()
        {
            // TODO: unit test for the property 'RequestedStatus' 
        }
        
        /// <summary>
        /// Test the property 'StationUri' 
        /// </summary>
        [Test]
        public void StationUriTest()
        {
            // TODO: unit test for the property 'StationUri' 
        }
        
        /// <summary>
        /// Test the property 'LastStationUri' 
        /// </summary>
        [Test]
        public void LastStationUriTest()
        {
            // TODO: unit test for the property 'LastStationUri' 
        }
        
        /// <summary>
        /// Test the property 'DefaultStationUri' 
        /// </summary>
        [Test]
        public void DefaultStationUriTest()
        {
            // TODO: unit test for the property 'DefaultStationUri' 
        }
        

    }

}
