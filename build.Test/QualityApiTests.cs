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
        /// Test GetConversationRecordings
        /// </summary>
        [Test]
        public void GetConversationRecordingsTest()
        {
            // TODO: add unit test for the method 'GetConversationRecordings'
            string conversationId = null; // TODO: replace null with proper value
            int? maxWaitMs = null; // TODO: replace null with proper value
            string formatId = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationRecordings(conversationId, maxWaitMs, formatId);
            Assert.IsInstanceOf<List<Recording>> (response, "response is List<Recording>"); 
        }
        
        /// <summary>
        /// Test GetConversationRecording
        /// </summary>
        [Test]
        public void GetConversationRecordingTest()
        {
            // TODO: add unit test for the method 'GetConversationRecording'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            int? maxWaitMs = null; // TODO: replace null with proper value
            string formatId = null; // TODO: replace null with proper value
            bool? download = null; // TODO: replace null with proper value
            string fileName = null; // TODO: replace null with proper value
            
            instance.GetConversationRecording(conversationId, recordingId, maxWaitMs, formatId, download, fileName);
             
        }
        
        /// <summary>
        /// Test PutConversationRecording
        /// </summary>
        [Test]
        public void PutConversationRecordingTest()
        {
            // TODO: add unit test for the method 'PutConversationRecording'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            Recording body = null; // TODO: replace null with proper value
            int? restoreDays = null; // TODO: replace null with proper value
            
            instance.PutConversationRecording(conversationId, recordingId, body, restoreDays);
             
        }
        
        /// <summary>
        /// Test GetConversationRecordingAnnotations
        /// </summary>
        [Test]
        public void GetConversationRecordingAnnotationsTest()
        {
            // TODO: add unit test for the method 'GetConversationRecordingAnnotations'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationRecordingAnnotations(conversationId, recordingId);
            Assert.IsInstanceOf<List<Annotation>> (response, "response is List<Annotation>"); 
        }
        
        /// <summary>
        /// Test PostConversationRecordingAnnotations
        /// </summary>
        [Test]
        public void PostConversationRecordingAnnotationsTest()
        {
            // TODO: add unit test for the method 'PostConversationRecordingAnnotations'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            Annotation body = null; // TODO: replace null with proper value
            
            var response = instance.PostConversationRecordingAnnotations(conversationId, recordingId, body);
            Assert.IsInstanceOf<Annotation> (response, "response is Annotation"); 
        }
        
        /// <summary>
        /// Test GetConversationRecordingAnnotation
        /// </summary>
        [Test]
        public void GetConversationRecordingAnnotationTest()
        {
            // TODO: add unit test for the method 'GetConversationRecordingAnnotation'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            string annotationId = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationRecordingAnnotation(conversationId, recordingId, annotationId);
            Assert.IsInstanceOf<Annotation> (response, "response is Annotation"); 
        }
        
        /// <summary>
        /// Test PutConversationRecordingAnnotation
        /// </summary>
        [Test]
        public void PutConversationRecordingAnnotationTest()
        {
            // TODO: add unit test for the method 'PutConversationRecordingAnnotation'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            string annotationId = null; // TODO: replace null with proper value
            Annotation body = null; // TODO: replace null with proper value
            
            var response = instance.PutConversationRecordingAnnotation(conversationId, recordingId, annotationId, body);
            Assert.IsInstanceOf<Annotation> (response, "response is Annotation"); 
        }
        
        /// <summary>
        /// Test DeleteConversationRecordingAnnotation
        /// </summary>
        [Test]
        public void DeleteConversationRecordingAnnotationTest()
        {
            // TODO: add unit test for the method 'DeleteConversationRecordingAnnotation'
            string conversationId = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            string annotationId = null; // TODO: replace null with proper value
            
            instance.DeleteConversationRecordingAnnotation(conversationId, recordingId, annotationId);
             
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
        /// Test GetCalibration
        /// </summary>
        [Test]
        public void GetCalibrationTest()
        {
            // TODO: add unit test for the method 'GetCalibration'
            string calibrationId = null; // TODO: replace null with proper value
            string calibratorId = null; // TODO: replace null with proper value
            
            var response = instance.GetCalibration(calibrationId, calibratorId);
            Assert.IsInstanceOf<Calibration> (response, "response is Calibration"); 
        }
        
        /// <summary>
        /// Test PutCalibration
        /// </summary>
        [Test]
        public void PutCalibrationTest()
        {
            // TODO: add unit test for the method 'PutCalibration'
            string calibrationId = null; // TODO: replace null with proper value
            Calibration body = null; // TODO: replace null with proper value
            
            var response = instance.PutCalibration(calibrationId, body);
            Assert.IsInstanceOf<Calibration> (response, "response is Calibration"); 
        }
        
        /// <summary>
        /// Test DeleteCalibration
        /// </summary>
        [Test]
        public void DeleteCalibrationTest()
        {
            // TODO: add unit test for the method 'DeleteCalibration'
            string calibrationId = null; // TODO: replace null with proper value
            string calibratorId = null; // TODO: replace null with proper value
            
            var response = instance.DeleteCalibration(calibrationId, calibratorId);
            Assert.IsInstanceOf<Calibration> (response, "response is Calibration"); 
        }
        
        /// <summary>
        /// Test GetConversationAudits
        /// </summary>
        [Test]
        public void GetConversationAuditsTest()
        {
            // TODO: add unit test for the method 'GetConversationAudits'
            string conversationId = null; // TODO: replace null with proper value
            int? pageSize = null; // TODO: replace null with proper value
            int? pageNumber = null; // TODO: replace null with proper value
            string sortBy = null; // TODO: replace null with proper value
            List<string> expand = null; // TODO: replace null with proper value
            string recordingId = null; // TODO: replace null with proper value
            string entityType = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationAudits(conversationId, pageSize, pageNumber, sortBy, expand, recordingId, entityType);
            Assert.IsInstanceOf<QualityAuditPage> (response, "response is QualityAuditPage"); 
        }
        
        /// <summary>
        /// Test PostConversationEvaluations
        /// </summary>
        [Test]
        public void PostConversationEvaluationsTest()
        {
            // TODO: add unit test for the method 'PostConversationEvaluations'
            string conversationId = null; // TODO: replace null with proper value
            Evaluation body = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.PostConversationEvaluations(conversationId, body, expand);
            Assert.IsInstanceOf<Evaluation> (response, "response is Evaluation"); 
        }
        
        /// <summary>
        /// Test GetConversationEvaluation
        /// </summary>
        [Test]
        public void GetConversationEvaluationTest()
        {
            // TODO: add unit test for the method 'GetConversationEvaluation'
            string conversationId = null; // TODO: replace null with proper value
            string evaluationId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.GetConversationEvaluation(conversationId, evaluationId, expand);
            Assert.IsInstanceOf<Evaluation> (response, "response is Evaluation"); 
        }
        
        /// <summary>
        /// Test PutConversationEvaluation
        /// </summary>
        [Test]
        public void PutConversationEvaluationTest()
        {
            // TODO: add unit test for the method 'PutConversationEvaluation'
            string conversationId = null; // TODO: replace null with proper value
            string evaluationId = null; // TODO: replace null with proper value
            Evaluation body = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.PutConversationEvaluation(conversationId, evaluationId, body, expand);
            Assert.IsInstanceOf<Evaluation> (response, "response is Evaluation"); 
        }
        
        /// <summary>
        /// Test DeleteConversationEvaluation
        /// </summary>
        [Test]
        public void DeleteConversationEvaluationTest()
        {
            // TODO: add unit test for the method 'DeleteConversationEvaluation'
            string conversationId = null; // TODO: replace null with proper value
            string evaluationId = null; // TODO: replace null with proper value
            string expand = null; // TODO: replace null with proper value
            
            var response = instance.DeleteConversationEvaluation(conversationId, evaluationId, expand);
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
