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
    public class VoicemailMailboxInfoTests
    {
        private VoicemailMailboxInfo instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new VoicemailMailboxInfo();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of VoicemailMailboxInfo
        /// </summary>
        [Test]
        public void VoicemailMailboxInfoInstanceTest()
        {
            Assert.IsInstanceOf<VoicemailMailboxInfo> (instance, "instance is a VoicemailMailboxInfo");
        }

        
        /// <summary>
        /// Test the property 'UsageSizeBytes' 
        /// </summary>
        [Test]
        public void UsageSizeBytesTest()
        {
            // TODO: unit test for the property 'UsageSizeBytes' 
        }
        
        /// <summary>
        /// Test the property 'TotalCount' 
        /// </summary>
        [Test]
        public void TotalCountTest()
        {
            // TODO: unit test for the property 'TotalCount' 
        }
        
        /// <summary>
        /// Test the property 'UnreadCount' 
        /// </summary>
        [Test]
        public void UnreadCountTest()
        {
            // TODO: unit test for the property 'UnreadCount' 
        }
        
        /// <summary>
        /// Test the property 'VoicemailPolicy' 
        /// </summary>
        [Test]
        public void VoicemailPolicyTest()
        {
            // TODO: unit test for the property 'VoicemailPolicy' 
        }
        
        /// <summary>
        /// Test the property 'CreatedDate' 
        /// </summary>
        [Test]
        public void CreatedDateTest()
        {
            // TODO: unit test for the property 'CreatedDate' 
        }
        
        /// <summary>
        /// Test the property 'ModifiedDate' 
        /// </summary>
        [Test]
        public void ModifiedDateTest()
        {
            // TODO: unit test for the property 'ModifiedDate' 
        }
        

    }

}
