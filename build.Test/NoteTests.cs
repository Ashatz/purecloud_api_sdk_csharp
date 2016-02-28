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
    public class NoteTests
    {
        private Note instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Note();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Note
        /// </summary>
        [Test]
        public void NoteInstanceTest()
        {
            Assert.IsInstanceOf<Note> (instance, "instance is a Note");
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
        /// Test the property 'NoteText' 
        /// </summary>
        [Test]
        public void NoteTextTest()
        {
            // TODO: unit test for the property 'NoteText' 
        }
        
        /// <summary>
        /// Test the property 'ModifyDate' 
        /// </summary>
        [Test]
        public void ModifyDateTest()
        {
            // TODO: unit test for the property 'ModifyDate' 
        }
        
        /// <summary>
        /// Test the property 'CreateDate' 
        /// </summary>
        [Test]
        public void CreateDateTest()
        {
            // TODO: unit test for the property 'CreateDate' 
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
