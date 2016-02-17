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
    public class CreateTemplateFromScriptRequestDataTests
    {
        private CreateTemplateFromScriptRequestData instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CreateTemplateFromScriptRequestData();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of CreateTemplateFromScriptRequestData
        /// </summary>
        [Test]
        public void CreateTemplateFromScriptRequestDataInstanceTest()
        {
            Assert.IsInstanceOf<CreateTemplateFromScriptRequestData> (instance, "instance is a CreateTemplateFromScriptRequestData");
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
        /// Test the property 'Tags' 
        /// </summary>
        [Test]
        public void TagsTest()
        {
            // TODO: unit test for the property 'Tags' 
        }
        
        /// <summary>
        /// Test the property 'ScriptId' 
        /// </summary>
        [Test]
        public void ScriptIdTest()
        {
            // TODO: unit test for the property 'ScriptId' 
        }
        
        /// <summary>
        /// Test the property 'UserId' 
        /// </summary>
        [Test]
        public void UserIdTest()
        {
            // TODO: unit test for the property 'UserId' 
        }
        

    }

}
