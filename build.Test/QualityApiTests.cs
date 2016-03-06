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
    public class QualityApiTests
    {
        private QualityApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new QualityApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of QualityApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<QualityApi> (instance, "instance is a QualityApi");
        }

        
        /// <summary>
        /// Test GetConversationIdRecordings
        /// </summary>
        [Test]
        public void GetConversationIdRecordingsTest()
        {
            // TODO: add unit test for the method 'GetConversationIdRecordings'
            string conversationId = null; // TODO: replace null with proper value
            int? maxWaitMs = null; // TODO: replace null with proper value
            string formatId = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationIdRecordings(conversationId, maxWaitMs, formatId);
            Assert.IsInstanceOf<List<Recording>> (response, "response is List<Recording>"); 
        }
        
        /// <summary>
        /// Test GetConversationIdRecordingsRecordingId
        /// </summary>
        [Test]
        public void GetConversationIdRecordingsRecordingIdTest()
        {
            // TODO: add unit test for the method 'GetConversationIdRecordingsRecordingId'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            int? maxWaitMs = null; // TODO: replace null with proper value
            string formatId = null; // TODO: replace null with proper value
            bool? download = null; // TODO: replace null with proper value
            string fileName = null; // TODO: replace null with proper value
            
            instance.GetConversationIdRecordingsRecordingId(conversationId, recordingId, maxWaitMs, formatId, download, fileName);
             
        }
        
        /// <summary>
        /// Test PutConversationIdRecordingsRecordingId
        /// </summary>
        [Test]
        public void PutConversationIdRecordingsRecordingIdTest()
        {
            // TODO: add unit test for the method 'PutConversationIdRecordingsRecordingId'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            Recording body = null; // TODO: replace null with proper value
            int? restoreDays = null; // TODO: replace null with proper value
            
            instance.PutConversationIdRecordingsRecordingId(conversationId, recordingId, body, restoreDays);
             
        }
        
        /// <summary>
        /// Test GetConversationIdRecordingsRecordingIdAnnotations
        /// </summary>
        [Test]
        public void GetConversationIdRecordingsRecordingIdAnnotationsTest()
        {
            // TODO: add unit test for the method 'GetConversationIdRecordingsRecordingIdAnnotations'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationIdRecordingsRecordingIdAnnotations(conversationId, recordingId);
            Assert.IsInstanceOf<List<Annotation>> (response, "response is List<Annotation>"); 
        }
        
        /// <summary>
        /// Test PostConversationIdRecordingsRecordingIdAnnotations
        /// </summary>
        [Test]
        public void PostConversationIdRecordingsRecordingIdAnnotationsTest()
        {
            // TODO: add unit test for the method 'PostConversationIdRecordingsRecordingIdAnnotations'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            Annotation body = null; // TODO: replace null with proper value
            
            var response = instance.PostConversationIdRecordingsRecordingIdAnnotations(conversationId, recordingId, body);
            Assert.IsInstanceOf<Annotation> (response, "response is Annotation"); 
        }
        
        /// <summary>
        /// Test GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId
        /// </summary>
        [Test]
        public void GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdTest()
        {
            // TODO: add unit test for the method 'GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            string annotationId = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId(conversationId, recordingId, annotationId);
            Assert.IsInstanceOf<Annotation> (response, "response is Annotation"); 
        }
        
        /// <summary>
        /// Test PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId
        /// </summary>
        [Test]
        public void PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdTest()
        {
            // TODO: add unit test for the method 'PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            string annotationId = null; // TODO: replace null with proper value
            Annotation body = null; // TODO: replace null with proper value
            
            var response = instance.PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId(conversationId, recordingId, annotationId, body);
            Assert.IsInstanceOf<Annotation> (response, "response is Annotation"); 
        }
        
        /// <summary>
        /// Test DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId
        /// </summary>
        [Test]
        public void DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdTest()
        {
            // TODO: add unit test for the method 'DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            string annotationId = null; // TODO: replace null with proper value
            
            instance.DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId(conversationId, recordingId, annotationId);
             
        }
        
        /// <summary>
        /// Test GetAgentsActivity
        /// </summary>
        [Test]
        public void GetAgentsActivityTest()
        {
            // TODO: add unit test for the method 'GetAgentsActivity'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            DateTime? startTime = null; // TODO: replace null with proper value
            DateTime? endTime = null; // TODO: replace null with proper value
            List<string> agentUserId = null; // TODO: replace null with proper value
            string evaluatorUserId = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            string group = null; // TODO: replace null with proper value
            
            var response = instance.GetAgentsActivity(pageSize, pageNumber, sortBy, expand, startTime, endTime, agentUserId, evaluatorUserId, name, group);
            Assert.IsInstanceOf<AgentActivityEntityListing> (response, "response is AgentActivityEntityListing"); 
        }
        
        /// <summary>
        /// Test GetCalibrations
        /// </summary>
        [Test]
        public void GetCalibrationsTest()
        {
            // TODO: add unit test for the method 'GetCalibrations'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            string conversationId = null; // TODO: replace null with proper value
            DateTime? startTime = null; // TODO: replace null with proper value
            DateTime? endTime = null; // TODO: replace null with proper value
            string calibratorId = null; // TODO: replace null with proper value
            
            var response = instance.GetCalibrations(pageSize, pageNumber, sortBy, expand, conversationId, startTime, endTime, calibratorId);
            Assert.IsInstanceOf<CalibrationEntityListing> (response, "response is CalibrationEntityListing"); 
        }
        
        /// <summary>
        /// Test PostCalibrations
        /// </summary>
        [Test]
        public void PostCalibrationsTest()
        {
            // TODO: add unit test for the method 'PostCalibrations'
            Calibration body = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.PostCalibrations(body, expand);
            Assert.IsInstanceOf<Calibration> (response, "response is Calibration"); 
        }
        
        /// <summary>
        /// Test GetCalibrationsCalibrationId
        /// </summary>
        [Test]
        public void GetCalibrationsCalibrationIdTest()
        {
            // TODO: add unit test for the method 'GetCalibrationsCalibrationId'
            string calibrationId = null; // TODO: replace null with proper value
            string calibratorId = null; // TODO: replace null with proper value
            
            var response = instance.GetCalibrationsCalibrationId(calibrationId, calibratorId);
            Assert.IsInstanceOf<Calibration> (response, "response is Calibration"); 
        }
        
        /// <summary>
        /// Test PutCalibrationsCalibrationId
        /// </summary>
        [Test]
        public void PutCalibrationsCalibrationIdTest()
        {
            // TODO: add unit test for the method 'PutCalibrationsCalibrationId'
            string calibrationId = null; // TODO: replace null with proper value
            Calibration body = null; // TODO: replace null with proper value
            
            var response = instance.PutCalibrationsCalibrationId(calibrationId, body);
            Assert.IsInstanceOf<Calibration> (response, "response is Calibration"); 
        }
        
        /// <summary>
        /// Test DeleteCalibrationsCalibrationId
        /// </summary>
        [Test]
        public void DeleteCalibrationsCalibrationIdTest()
        {
            // TODO: add unit test for the method 'DeleteCalibrationsCalibrationId'
            string calibrationId = null; // TODO: replace null with proper value
            string calibratorId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteCalibrationsCalibrationId(calibrationId, calibratorId);
            Assert.IsInstanceOf<Calibration> (response, "response is Calibration"); 
        }
        
        /// <summary>
        /// Test GetConversationsConversationIdAudits
        /// </summary>
        [Test]
        public void GetConversationsConversationIdAuditsTest()
        {
            // TODO: add unit test for the method 'GetConversationsConversationIdAudits'
            string conversationId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            string entityType = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationsConversationIdAudits(conversationId, pageSize, pageNumber, sortBy, expand, recordingId, entityType);
            Assert.IsInstanceOf<QualityAuditPage> (response, "response is QualityAuditPage"); 
        }
        
        /// <summary>
        /// Test PostConversationsConversationIdEvaluations
        /// </summary>
        [Test]
        public void PostConversationsConversationIdEvaluationsTest()
        {
            // TODO: add unit test for the method 'PostConversationsConversationIdEvaluations'
            string conversationId = null; // TODO: replace null with proper value
            Evaluation body = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.PostConversationsConversationIdEvaluations(conversationId, body, expand);
            Assert.IsInstanceOf<Evaluation> (response, "response is Evaluation"); 
        }
        
        /// <summary>
        /// Test GetConversationsConversationIdEvaluationsEvaluationId
        /// </summary>
        [Test]
        public void GetConversationsConversationIdEvaluationsEvaluationIdTest()
        {
            // TODO: add unit test for the method 'GetConversationsConversationIdEvaluationsEvaluationId'
            string conversationId = null; // TODO: replace null with proper value
            string evaluationId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationsConversationIdEvaluationsEvaluationId(conversationId, evaluationId, expand);
            Assert.IsInstanceOf<Evaluation> (response, "response is Evaluation"); 
        }
        
        /// <summary>
        /// Test PutConversationsConversationIdEvaluationsEvaluationId
        /// </summary>
        [Test]
        public void PutConversationsConversationIdEvaluationsEvaluationIdTest()
        {
            // TODO: add unit test for the method 'PutConversationsConversationIdEvaluationsEvaluationId'
            string conversationId = null; // TODO: replace null with proper value
            string evaluationId = null; // TODO: replace null with proper value
            Evaluation body = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.PutConversationsConversationIdEvaluationsEvaluationId(conversationId, evaluationId, body, expand);
            Assert.IsInstanceOf<Evaluation> (response, "response is Evaluation"); 
        }
        
        /// <summary>
        /// Test DeleteConversationsConversationIdEvaluationsEvaluationId
        /// </summary>
        [Test]
        public void DeleteConversationsConversationIdEvaluationsEvaluationIdTest()
        {
            // TODO: add unit test for the method 'DeleteConversationsConversationIdEvaluationsEvaluationId'
            string conversationId = null; // TODO: replace null with proper value
            string evaluationId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.DeleteConversationsConversationIdEvaluationsEvaluationId(conversationId, evaluationId, expand);
            Assert.IsInstanceOf<Evaluation> (response, "response is Evaluation"); 
        }
        
        /// <summary>
        /// Test GetEvaluationsQuery
        /// </summary>
        [Test]
        public void GetEvaluationsQueryTest()
        {
            // TODO: add unit test for the method 'GetEvaluationsQuery'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            string conversationId = null; // TODO: replace null with proper value
            string agentUserId = null; // TODO: replace null with proper value
            string evaluatorUserId = null; // TODO: replace null with proper value
            string queueId = null; // TODO: replace null with proper value
            string startTime = null; // TODO: replace null with proper value
            string endTime = null; // TODO: replace null with proper value
            List<string> evaluationState = null; // TODO: replace null with proper value
            bool? isReleased = null; // TODO: replace null with proper value
            bool? agentHasRead = null; // TODO: replace null with proper value
            bool? expandAnswerTotalScores = null; // TODO: replace null with proper value
            int? maximum = null; // TODO: replace null with proper value
            
            var response = instance.GetEvaluationsQuery(pageSize, pageNumber, sortBy, expand, conversationId, agentUserId, evaluatorUserId, queueId, startTime, endTime, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum);
            Assert.IsInstanceOf<EvaluationEntityListing> (response, "response is EvaluationEntityListing"); 
        }
        
        /// <summary>
        /// Test PostEvaluationsQuery
        /// </summary>
        [Test]
        public void PostEvaluationsQueryTest()
        {
            // TODO: add unit test for the method 'PostEvaluationsQuery'
            EvaluationQueryRequest body = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.PostEvaluationsQuery(body, expand);
            Assert.IsInstanceOf<EvaluationEntityListing> (response, "response is EvaluationEntityListing"); 
        }
        
        /// <summary>
        /// Test PostEvaluationsScoring
        /// </summary>
        [Test]
        public void PostEvaluationsScoringTest()
        {
            // TODO: add unit test for the method 'PostEvaluationsScoring'
            EvaluationFormAndScoringSet body = null; // TODO: replace null with proper value
            
            var response = instance.PostEvaluationsScoring(body);
            Assert.IsInstanceOf<EvaluationScoringSet> (response, "response is EvaluationScoringSet"); 
        }
        
        /// <summary>
        /// Test GetEvaluatorsActivity
        /// </summary>
        [Test]
        public void GetEvaluatorsActivityTest()
        {
            // TODO: add unit test for the method 'GetEvaluatorsActivity'
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            DateTime? startTime = null; // TODO: replace null with proper value
            DateTime? endTime = null; // TODO: replace null with proper value
            string name = null; // TODO: replace null with proper value
            List<string> permission = null; // TODO: replace null with proper value
            string group = null; // TODO: replace null with proper value
            
            var response = instance.GetEvaluatorsActivity(pageSize, pageNumber, sortBy, expand, startTime, endTime, name, permission, group);
            Assert.IsInstanceOf<EvaluatorActivityEntityListing> (response, "response is EvaluatorActivityEntityListing"); 
        }
        
    }

}
