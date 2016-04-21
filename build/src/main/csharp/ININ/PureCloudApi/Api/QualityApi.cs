using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ININ.PureCloudApi.Client;
using ININ.PureCloudApi.Model;

namespace ININ.PureCloudApi.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IQualityApi
    {
        #region Synchronous Operations
<<<<<<< HEAD
        /// <summary>
        /// Get all of a Conversation&#39;s Recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. (optional, default to 5000)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>List&lt;Recording&gt;</returns>
        List<Recording> ConversationsConversationidRecordingsGet (string conversationId, int? maxWaitMs = null, string formatId = null);

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. (optional, default to 5000)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>ApiResponse of List&lt;Recording&gt;</returns>
        ApiResponse<List<Recording>> ConversationsConversationidRecordingsGetWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null);
        /// <summary>
        /// Delete annotation
=======
        /// <summary>
        /// Delete a calibration by id.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns></returns>
        void ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete (string conversationId, string recordingId, string annotationId);

        /// <summary>
        /// Delete annotation
=======
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Calibration</returns>
        Calibration DeleteCalibrationsCalibrationId (string calibrationId, string calibratorId);

        /// <summary>
        /// Delete a calibration by id.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDeleteWithHttpInfo (string conversationId, string recordingId, string annotationId);
        /// <summary>
        /// Get annotation
=======
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> DeleteCalibrationsCalibrationIdWithHttpInfo (string calibrationId, string calibratorId);
        /// <summary>
        /// Delete an evaluation
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Annotation</returns>
        Annotation ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet (string conversationId, string recordingId, string annotationId);

        /// <summary>
        /// Get annotation
=======
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        Evaluation DeleteConversationsConversationIdEvaluationsEvaluationId (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Delete an evaluation
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>ApiResponse of Annotation</returns>
        ApiResponse<Annotation> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGetWithHttpInfo (string conversationId, string recordingId, string annotationId);
        /// <summary>
        /// Update annotation
=======
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        ApiResponse<Evaluation> DeleteConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo (string conversationId, string evaluationId, string expand = null);
        /// <summary>
        /// Delete an evaluation form.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>Annotation</returns>
        Annotation ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut (string conversationId, string recordingId, string annotationId, Annotation body = null);

        /// <summary>
        /// Update annotation
=======
        /// <param name="formId">Form ID</param>
        /// <returns>string</returns>
        string DeleteFormsFormId (string formId);

        /// <summary>
        /// Delete an evaluation form.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>ApiResponse of Annotation</returns>
        ApiResponse<Annotation> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPutWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body = null);
        /// <summary>
        /// Get annotations for recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>List&lt;Annotation&gt;</returns>
        List<Annotation> ConversationsConversationidRecordingsRecordingidAnnotationsGet (string conversationId, string recordingId);

        /// <summary>
        /// Get annotations for recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>ApiResponse of List&lt;Annotation&gt;</returns>
        ApiResponse<List<Annotation>> ConversationsConversationidRecordingsRecordingidAnnotationsGetWithHttpInfo (string conversationId, string recordingId);
        /// <summary>
        /// Create annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>Annotation</returns>
        Annotation ConversationsConversationidRecordingsRecordingidAnnotationsPost (string conversationId, string recordingId, Annotation body = null);

        /// <summary>
        /// Create annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>ApiResponse of Annotation</returns>
        ApiResponse<Annotation> ConversationsConversationidRecordingsRecordingidAnnotationsPostWithHttpInfo (string conversationId, string recordingId, Annotation body = null);
        /// <summary>
        /// Gets a specific recording.
=======
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteFormsFormIdWithHttpInfo (string formId);
        /// <summary>
        /// Gets a list of Agent Activities
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>AgentActivityEntityListing</returns>
        AgentActivityEntityListing GetAgentsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);

        /// <summary>
        /// Gets a list of Agent Activities
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>ApiResponse of AgentActivityEntityListing</returns>
        ApiResponse<AgentActivityEntityListing> GetAgentsActivityWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);
        /// <summary>
        /// Get the list of calibrations
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for completion. (optional)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns></returns>
        void ConversationsConversationidRecordingsRecordingidGet (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null);

        /// <summary>
        /// Gets a specific recording.
=======
        /// <param name="calibratorId">user id of calibrator</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <returns>CalibrationEntityListing</returns>
        CalibrationEntityListing GetCalibrations (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null);

        /// <summary>
        /// Get the list of calibrations
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for completion. (optional)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConversationsConversationidRecordingsRecordingidGetWithHttpInfo (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null);
        /// <summary>
        /// Updates the retention records on a recording.
=======
        /// <param name="calibratorId">user id of calibrator</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <returns>ApiResponse of CalibrationEntityListing</returns>
        ApiResponse<CalibrationEntityListing> GetCalibrationsWithHttpInfo (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null);
        /// <summary>
        /// Get a calibration by id.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays&#x3D;10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated. (optional)</param>
        /// <returns></returns>
        void ConversationsConversationidRecordingsRecordingidPut (string conversationId, string recordingId, Recording body, int? restoreDays = null);

        /// <summary>
        /// Updates the retention records on a recording.
=======
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Calibration</returns>
        Calibration GetCalibrationsCalibrationId (string calibrationId, string calibratorId);

        /// <summary>
        /// Get a calibration by id.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays&#x3D;10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConversationsConversationidRecordingsRecordingidPutWithHttpInfo (string conversationId, string recordingId, Recording body, int? restoreDays = null);
        /// <summary>
        /// Gets a list of Agent Activities
=======
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> GetCalibrationsCalibrationIdWithHttpInfo (string calibrationId, string calibratorId);
        /// <summary>
        /// Get audits for conversation or recording
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
=======
        /// <param name="conversationId">Conversation ID</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
<<<<<<< HEAD
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>AgentActivityEntityListing</returns>
        AgentActivityEntityListing QualityAgentsActivityGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);

        /// <summary>
        /// Gets a list of Agent Activities
=======
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>QualityAuditPage</returns>
        QualityAuditPage GetConversationsConversationIdAudits (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null);

        /// <summary>
        /// Get audits for conversation or recording
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
=======
        /// <param name="conversationId">Conversation ID</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
<<<<<<< HEAD
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>ApiResponse of AgentActivityEntityListing</returns>
        ApiResponse<AgentActivityEntityListing> QualityAgentsActivityGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);
        /// <summary>
        /// Delete a calibration by id.
=======
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>ApiResponse of QualityAuditPage</returns>
        ApiResponse<QualityAuditPage> GetConversationsConversationIdAuditsWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null);
        /// <summary>
        /// Get an evaluation
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Calibration</returns>
        Calibration QualityCalibrationsCalibrationidDelete (string calibrationId, string calibratorId = null);

        /// <summary>
        /// Delete a calibration by id.
=======
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>Evaluation</returns>
        Evaluation GetConversationsConversationIdEvaluationsEvaluationId (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Get an evaluation
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> QualityCalibrationsCalibrationidDeleteWithHttpInfo (string calibrationId, string calibratorId = null);
        /// <summary>
        /// Get a calibration by id.
=======
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        ApiResponse<Evaluation> GetConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo (string conversationId, string evaluationId, string expand = null);
        /// <summary>
        /// Queries Evaluations and returns a paged list
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Calibration</returns>
        Calibration QualityCalibrationsCalibrationidGet (string calibrationId, string calibratorId = null);

        /// <summary>
        /// Get a calibration by id.
=======
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>EvaluationEntityListing</returns>
        EvaluationEntityListing GetEvaluationsQuery (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);

        /// <summary>
        /// Queries Evaluations and returns a paged list
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> QualityCalibrationsCalibrationidGetWithHttpInfo (string calibrationId, string calibratorId = null);
        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
=======
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        ApiResponse<EvaluationEntityListing> GetEvaluationsQueryWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);
        /// <summary>
        /// Get an evaluator activity
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Calibration</returns>
        Calibration QualityCalibrationsCalibrationidPut (string calibrationId, Calibration body = null);

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
=======
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>EvaluatorActivityEntityListing</returns>
        EvaluatorActivityEntityListing GetEvaluatorsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null);

        /// <summary>
        /// Get an evaluator activity
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> QualityCalibrationsCalibrationidPutWithHttpInfo (string calibrationId, Calibration body = null);
        /// <summary>
        /// Get the list of calibrations
=======
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>ApiResponse of EvaluatorActivityEntityListing</returns>
        ApiResponse<EvaluatorActivityEntityListing> GetEvaluatorsActivityWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null);
        /// <summary>
        /// Get the list of evaluation forms
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
<<<<<<< HEAD
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="calibratorId">user id of calibrator (optional)</param>
        /// <returns>CalibrationEntityListing</returns>
        CalibrationEntityListing QualityCalibrationsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null);

        /// <summary>
        /// Get the list of calibrations
=======
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>EvaluationFormEntityListing</returns>
        EvaluationFormEntityListing GetForms (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null);

        /// <summary>
        /// Get the list of evaluation forms
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
<<<<<<< HEAD
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="calibratorId">user id of calibrator (optional)</param>
        /// <returns>ApiResponse of CalibrationEntityListing</returns>
        ApiResponse<CalibrationEntityListing> QualityCalibrationsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null);
        /// <summary>
        /// Create a calibration
=======
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        ApiResponse<EvaluationFormEntityListing> GetFormsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null);
        /// <summary>
        /// Get an evaluation form
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Calibration</returns>
        Calibration QualityCalibrationsPost (Calibration body = null, string expand = null);

        /// <summary>
        /// Create a calibration
=======
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm GetFormsFormId (string formId);

        /// <summary>
        /// Get an evaluation form
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> QualityCalibrationsPostWithHttpInfo (Calibration body = null, string expand = null);
        /// <summary>
        /// Get audits for conversation or recording
=======
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> GetFormsFormIdWithHttpInfo (string formId);
        /// <summary>
        /// Gets all the revisions for a specific evaluation.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>QualityAuditPage</returns>
        QualityAuditPage QualityConversationsConversationidAuditsGet (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null);

        /// <summary>
        /// Get audits for conversation or recording
=======
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>EvaluationFormEntityListing</returns>
        EvaluationFormEntityListing GetFormsFormIdVersions (string formId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets all the revisions for a specific evaluation.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>ApiResponse of QualityAuditPage</returns>
        ApiResponse<QualityAuditPage> QualityConversationsConversationidAuditsGetWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null);
        /// <summary>
        /// Delete an evaluation
=======
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        ApiResponse<EvaluationFormEntityListing> GetFormsFormIdVersionsWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get the published evaluation forms.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        Evaluation QualityConversationsConversationidEvaluationsEvaluationidDelete (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Delete an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        ApiResponse<Evaluation> QualityConversationsConversationidEvaluationsEvaluationidDeleteWithHttpInfo (string conversationId, string evaluationId, string expand = null);
        /// <summary>
        /// Get an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>Evaluation</returns>
        Evaluation QualityConversationsConversationidEvaluationsEvaluationidGet (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Get an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        ApiResponse<Evaluation> QualityConversationsConversationidEvaluationsEvaluationidGetWithHttpInfo (string conversationId, string evaluationId, string expand = null);
        /// <summary>
        /// Update an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        Evaluation QualityConversationsConversationidEvaluationsEvaluationidPut (string conversationId, string evaluationId, Evaluation body = null, string expand = null);

        /// <summary>
        /// Update an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        ApiResponse<Evaluation> QualityConversationsConversationidEvaluationsEvaluationidPutWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null);
        /// <summary>
        /// Create an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        Evaluation QualityConversationsConversationidEvaluationsPost (string conversationId, Evaluation body = null, string expand = null);

        /// <summary>
        /// Create an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        ApiResponse<Evaluation> QualityConversationsConversationidEvaluationsPostWithHttpInfo (string conversationId, Evaluation body = null, string expand = null);
        /// <summary>
        /// Queries Evaluations and returns a paged list
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>EvaluationEntityListing</returns>
        EvaluationEntityListing QualityEvaluationsQueryGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);

        /// <summary>
        /// Queries Evaluations and returns a paged list
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        ApiResponse<EvaluationEntityListing> QualityEvaluationsQueryGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);
        /// <summary>
        /// Query evaluations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">evaluator,agent (optional)</param>
        /// <returns>EvaluationEntityListing</returns>
        EvaluationEntityListing QualityEvaluationsQueryPost (EvaluationQueryRequest body = null, string expand = null);

        /// <summary>
        /// Query evaluations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">evaluator,agent (optional)</param>
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        ApiResponse<EvaluationEntityListing> QualityEvaluationsQueryPostWithHttpInfo (EvaluationQueryRequest body = null, string expand = null);
        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>EvaluationScoringSet</returns>
        EvaluationScoringSet QualityEvaluationsScoringPost (EvaluationFormAndScoringSet body = null);

        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>ApiResponse of EvaluationScoringSet</returns>
        ApiResponse<EvaluationScoringSet> QualityEvaluationsScoringPostWithHttpInfo (EvaluationFormAndScoringSet body = null);
        /// <summary>
        /// Get an evaluator activity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>EvaluatorActivityEntityListing</returns>
        EvaluatorActivityEntityListing QualityEvaluatorsActivityGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null);

        /// <summary>
        /// Get an evaluator activity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>ApiResponse of EvaluatorActivityEntityListing</returns>
        ApiResponse<EvaluatorActivityEntityListing> QualityEvaluatorsActivityGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get all of a Conversation&#39;s Recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. (optional, default to 5000)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>Task of List&lt;Recording&gt;</returns>
        System.Threading.Tasks.Task<List<Recording>> ConversationsConversationidRecordingsGetAsync (string conversationId, int? maxWaitMs = null, string formatId = null);

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. (optional, default to 5000)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>Task of ApiResponse (List&lt;Recording&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Recording>>> ConversationsConversationidRecordingsGetAsyncWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null);
        /// <summary>
        /// Delete annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDeleteAsync (string conversationId, string recordingId, string annotationId);
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>EvaluationFormEntityListing</returns>
        EvaluationFormEntityListing GetPublishedforms (int? pageSize = null, int? pageNumber = null, string name = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDeleteAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId);
        /// <summary>
        /// Get annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of Annotation</returns>
        System.Threading.Tasks.Task<Annotation> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGetAsync (string conversationId, string recordingId, string annotationId);

        /// <summary>
        /// Get annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Annotation>> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGetAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId);
        /// <summary>
        /// Update annotation
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        ApiResponse<EvaluationFormEntityListing> GetPublishedformsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null);
        /// <summary>
        /// Get the published evaluation forms.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>Task of Annotation</returns>
        System.Threading.Tasks.Task<Annotation> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPutAsync (string conversationId, string recordingId, string annotationId, Annotation body = null);

        /// <summary>
        /// Update annotation
=======
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm GetPublishedformsFormId (string formId);

        /// <summary>
        /// Get the published evaluation forms.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Annotation>> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPutAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body = null);
        /// <summary>
        /// Get annotations for recording
=======
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> GetPublishedformsFormIdWithHttpInfo (string formId);
        /// <summary>
        /// Create a calibration
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of List&lt;Annotation&gt;</returns>
        System.Threading.Tasks.Task<List<Annotation>> ConversationsConversationidRecordingsRecordingidAnnotationsGetAsync (string conversationId, string recordingId);

        /// <summary>
        /// Get annotations for recording
=======
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Calibration</returns>
        Calibration PostCalibrations (Calibration body = null, string expand = null);

        /// <summary>
        /// Create a calibration
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of ApiResponse (List&lt;Annotation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Annotation>>> ConversationsConversationidRecordingsRecordingidAnnotationsGetAsyncWithHttpInfo (string conversationId, string recordingId);
        /// <summary>
        /// Create annotation
=======
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> PostCalibrationsWithHttpInfo (Calibration body = null, string expand = null);
        /// <summary>
        /// Create an evaluation
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>Task of Annotation</returns>
        System.Threading.Tasks.Task<Annotation> ConversationsConversationidRecordingsRecordingidAnnotationsPostAsync (string conversationId, string recordingId, Annotation body = null);

        /// <summary>
        /// Create annotation
=======
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        Evaluation PostConversationsConversationIdEvaluations (string conversationId, Evaluation body = null, string expand = null);

        /// <summary>
        /// Create an evaluation
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Annotation>> ConversationsConversationidRecordingsRecordingidAnnotationsPostAsyncWithHttpInfo (string conversationId, string recordingId, Annotation body = null);
        /// <summary>
        /// Gets a specific recording.
=======
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        ApiResponse<Evaluation> PostConversationsConversationIdEvaluationsWithHttpInfo (string conversationId, Evaluation body = null, string expand = null);
        /// <summary>
        /// Query for evaluation aggregates
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for completion. (optional)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConversationsConversationidRecordingsRecordingidGetAsync (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null);

        /// <summary>
        /// Gets a specific recording.
=======
        /// <param name="body">query (optional)</param>
        /// <returns>AggregateQueryResponse</returns>
        AggregateQueryResponse PostEvaluationsAggregatesQuery (AggregationQuery body = null);

        /// <summary>
        /// Query for evaluation aggregates
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for completion. (optional)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidRecordingsRecordingidGetAsyncWithHttpInfo (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null);
        /// <summary>
        /// Updates the retention records on a recording.
=======
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of AggregateQueryResponse</returns>
        ApiResponse<AggregateQueryResponse> PostEvaluationsAggregatesQueryWithHttpInfo (AggregationQuery body = null);
        /// <summary>
        /// Score evaluation
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays&#x3D;10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated. (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConversationsConversationidRecordingsRecordingidPutAsync (string conversationId, string recordingId, Recording body, int? restoreDays = null);

        /// <summary>
        /// Updates the retention records on a recording.
=======
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>EvaluationScoringSet</returns>
        EvaluationScoringSet PostEvaluationsScoring (EvaluationFormAndScoringSet body = null);

        /// <summary>
        /// Score evaluation
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays&#x3D;10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidRecordingsRecordingidPutAsyncWithHttpInfo (string conversationId, string recordingId, Recording body, int? restoreDays = null);
        /// <summary>
        /// Gets a list of Agent Activities
=======
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>ApiResponse of EvaluationScoringSet</returns>
        ApiResponse<EvaluationScoringSet> PostEvaluationsScoringWithHttpInfo (EvaluationFormAndScoringSet body = null);
        /// <summary>
        /// Create an evaluation form.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of AgentActivityEntityListing</returns>
        System.Threading.Tasks.Task<AgentActivityEntityListing> QualityAgentsActivityGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);

        /// <summary>
        /// Gets a list of Agent Activities
=======
        /// <param name="body"> (optional)</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm PostForms (EvaluationForm body = null);

        /// <summary>
        /// Create an evaluation form.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of ApiResponse (AgentActivityEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AgentActivityEntityListing>> QualityAgentsActivityGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);
        /// <summary>
        /// Delete a calibration by id.
=======
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> PostFormsWithHttpInfo (EvaluationForm body = null);
        /// <summary>
        /// Publish an evaluation form.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> QualityCalibrationsCalibrationidDeleteAsync (string calibrationId, string calibratorId = null);

        /// <summary>
        /// Delete a calibration by id.
=======
        /// <param name="body"> (optional)</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm PostPublishedforms (EvaluationForm body = null);

        /// <summary>
        /// Publish an evaluation form.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> QualityCalibrationsCalibrationidDeleteAsyncWithHttpInfo (string calibrationId, string calibratorId = null);
=======
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> PostPublishedformsWithHttpInfo (EvaluationForm body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
<<<<<<< HEAD
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> QualityCalibrationsCalibrationidGetAsync (string calibrationId, string calibratorId = null);
=======
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Calibration</returns>
        Calibration PutCalibrationsCalibrationId (string calibrationId, Calibration body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
<<<<<<< HEAD
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> QualityCalibrationsCalibrationidGetAsyncWithHttpInfo (string calibrationId, string calibratorId = null);
=======
        /// <param name="body">Calibration (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> PutCalibrationsCalibrationIdWithHttpInfo (string calibrationId, Calibration body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Update an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> QualityCalibrationsCalibrationidPutAsync (string calibrationId, Calibration body = null);
=======
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        Evaluation PutConversationsConversationIdEvaluationsEvaluationId (string conversationId, string evaluationId, Evaluation body = null, string expand = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Update an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> QualityCalibrationsCalibrationidPutAsyncWithHttpInfo (string calibrationId, Calibration body = null);
        /// <summary>
        /// Get the list of calibrations
=======
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        ApiResponse<Evaluation> PutConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null);
        /// <summary>
        /// Update an evaluation form.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="calibratorId">user id of calibrator (optional)</param>
        /// <returns>Task of CalibrationEntityListing</returns>
        System.Threading.Tasks.Task<CalibrationEntityListing> QualityCalibrationsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null);

        /// <summary>
        /// Get the list of calibrations
=======
        /// <param name="formId">Form ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>EvaluationForm</returns>
        EvaluationForm PutFormsFormId (string formId, EvaluationForm body = null);

        /// <summary>
        /// Update an evaluation form.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="calibratorId">user id of calibrator (optional)</param>
        /// <returns>Task of ApiResponse (CalibrationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CalibrationEntityListing>> QualityCalibrationsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null);
=======
        /// <param name="formId">Form ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        ApiResponse<EvaluationForm> PutFormsFormIdWithHttpInfo (string formId, EvaluationForm body = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> QualityCalibrationsPostAsync (Calibration body = null, string expand = null);
=======
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> DeleteCalibrationsCalibrationIdAsync (string calibrationId, string calibratorId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> QualityCalibrationsPostAsyncWithHttpInfo (Calibration body = null, string expand = null);
=======
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> DeleteCalibrationsCalibrationIdAsyncWithHttpInfo (string calibrationId, string calibratorId);
        /// <summary>
        /// Delete an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        System.Threading.Tasks.Task<Evaluation> DeleteConversationsConversationIdEvaluationsEvaluationIdAsync (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Delete an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> DeleteConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>Task of QualityAuditPage</returns>
        System.Threading.Tasks.Task<QualityAuditPage> QualityConversationsConversationidAuditsGetAsync (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null);
=======
        /// <param name="formId">Form ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteFormsFormIdAsync (string formId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Delete an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
=======
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteFormsFormIdAsyncWithHttpInfo (string formId);
        /// <summary>
        /// Gets a list of Agent Activities
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of AgentActivityEntityListing</returns>
        System.Threading.Tasks.Task<AgentActivityEntityListing> GetAgentsActivityAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);

        /// <summary>
        /// Gets a list of Agent Activities
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of ApiResponse (AgentActivityEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AgentActivityEntityListing>> GetAgentsActivityAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);
        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibratorId">user id of calibrator</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
<<<<<<< HEAD
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>Task of ApiResponse (QualityAuditPage)</returns>
        System.Threading.Tasks.Task<ApiResponse<QualityAuditPage>> QualityConversationsConversationidAuditsGetAsyncWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null);
        /// <summary>
        /// Delete an evaluation
=======
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <returns>Task of CalibrationEntityListing</returns>
        System.Threading.Tasks.Task<CalibrationEntityListing> GetCalibrationsAsync (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null);

        /// <summary>
        /// Get the list of calibrations
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        System.Threading.Tasks.Task<Evaluation> QualityConversationsConversationidEvaluationsEvaluationidDeleteAsync (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Delete an evaluation
=======
        /// <param name="calibratorId">user id of calibrator</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <returns>Task of ApiResponse (CalibrationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CalibrationEntityListing>> GetCalibrationsAsyncWithHttpInfo (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null);
        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> GetCalibrationsCalibrationIdAsync (string calibrationId, string calibratorId);

        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> GetCalibrationsCalibrationIdAsyncWithHttpInfo (string calibrationId, string calibratorId);
        /// <summary>
        /// Get audits for conversation or recording
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> QualityConversationsConversationidEvaluationsEvaluationidDeleteAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null);
=======
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>Task of QualityAuditPage</returns>
        System.Threading.Tasks.Task<QualityAuditPage> GetConversationsConversationIdAuditsAsync (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get audits for conversation or recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>Task of ApiResponse (QualityAuditPage)</returns>
        System.Threading.Tasks.Task<ApiResponse<QualityAuditPage>> GetConversationsConversationIdAuditsAsyncWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null);
        /// <summary>
        /// Get an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>Task of Evaluation</returns>
        System.Threading.Tasks.Task<Evaluation> GetConversationsConversationIdEvaluationsEvaluationIdAsync (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Get an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
<<<<<<< HEAD
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> QualityConversationsConversationidEvaluationsEvaluationidGetAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null);
=======
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> GetConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null);
        /// <summary>
        /// Queries Evaluations and returns a paged list
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationEntityListing> GetEvaluationsQueryAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);

        /// <summary>
        /// Queries Evaluations and returns a paged list
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> GetEvaluationsQueryAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);
        /// <summary>
        /// Get an evaluator activity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of EvaluatorActivityEntityListing</returns>
        System.Threading.Tasks.Task<EvaluatorActivityEntityListing> GetEvaluatorsActivityAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get an evaluator activity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        System.Threading.Tasks.Task<Evaluation> QualityConversationsConversationidEvaluationsEvaluationidPutAsync (string conversationId, string evaluationId, Evaluation body = null, string expand = null);
=======
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of ApiResponse (EvaluatorActivityEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluatorActivityEntityListing>> GetEvaluatorsActivityAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null);
        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationFormEntityListing> GetFormsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Get the list of evaluation forms
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> QualityConversationsConversationidEvaluationsEvaluationidPutAsyncWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null);
        /// <summary>
        /// Create an evaluation
=======
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetFormsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null);
        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> GetFormsFormIdAsync (string formId);

        /// <summary>
        /// Get an evaluation form
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> GetFormsFormIdAsyncWithHttpInfo (string formId);
        /// <summary>
        /// Gets all the revisions for a specific evaluation.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationFormEntityListing> GetFormsFormIdVersionsAsync (string formId, int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Gets all the revisions for a specific evaluation.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        System.Threading.Tasks.Task<Evaluation> QualityConversationsConversationidEvaluationsPostAsync (string conversationId, Evaluation body = null, string expand = null);

        /// <summary>
        /// Create an evaluation
=======
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetFormsFormIdVersionsAsyncWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get the published evaluation forms.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> QualityConversationsConversationidEvaluationsPostAsyncWithHttpInfo (string conversationId, Evaluation body = null, string expand = null);
=======
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationFormEntityListing> GetPublishedformsAsync (int? pageSize = null, int? pageNumber = null, string name = null);

        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetPublishedformsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null);
        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> GetPublishedformsFormIdAsync (string formId);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Get the published evaluation forms.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationEntityListing> QualityEvaluationsQueryGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);

=======
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> GetPublishedformsFormIdAsyncWithHttpInfo (string formId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> QualityEvaluationsQueryGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);
=======
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> PostCalibrationsAsync (Calibration body = null, string expand = null);

        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> PostCalibrationsAsyncWithHttpInfo (Calibration body = null, string expand = null);
        /// <summary>
        /// Create an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        System.Threading.Tasks.Task<Evaluation> PostConversationsConversationIdEvaluationsAsync (string conversationId, Evaluation body = null, string expand = null);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Create an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">query (optional)</param>
        /// <param name="expand">evaluator,agent (optional)</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationEntityListing> QualityEvaluationsQueryPostAsync (EvaluationQueryRequest body = null, string expand = null);
=======
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> PostConversationsConversationIdEvaluationsAsyncWithHttpInfo (string conversationId, Evaluation body = null, string expand = null);
        /// <summary>
        /// Query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <returns>Task of AggregateQueryResponse</returns>
        System.Threading.Tasks.Task<AggregateQueryResponse> PostEvaluationsAggregatesQueryAsync (AggregationQuery body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Query for evaluation aggregates
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
<<<<<<< HEAD
        /// <param name="expand">evaluator,agent (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> QualityEvaluationsQueryPostAsyncWithHttpInfo (EvaluationQueryRequest body = null, string expand = null);
        /// <summary>
        /// Score evaluation
=======
        /// <returns>Task of ApiResponse (AggregateQueryResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AggregateQueryResponse>> PostEvaluationsAggregatesQueryAsyncWithHttpInfo (AggregationQuery body = null);
        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>Task of EvaluationScoringSet</returns>
        System.Threading.Tasks.Task<EvaluationScoringSet> PostEvaluationsScoringAsync (EvaluationFormAndScoringSet body = null);

        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationScoringSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationScoringSet>> PostEvaluationsScoringAsyncWithHttpInfo (EvaluationFormAndScoringSet body = null);
        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> PostFormsAsync (EvaluationForm body = null);

        /// <summary>
        /// Create an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> PostFormsAsyncWithHttpInfo (EvaluationForm body = null);
        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> PostPublishedformsAsync (EvaluationForm body = null);

        /// <summary>
        /// Publish an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> PostPublishedformsAsyncWithHttpInfo (EvaluationForm body = null);
        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>Task of EvaluationScoringSet</returns>
        System.Threading.Tasks.Task<EvaluationScoringSet> QualityEvaluationsScoringPostAsync (EvaluationFormAndScoringSet body = null);

        /// <summary>
        /// Score evaluation
=======
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> PutCalibrationsCalibrationIdAsync (string calibrationId, Calibration body = null);

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationScoringSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationScoringSet>> QualityEvaluationsScoringPostAsyncWithHttpInfo (EvaluationFormAndScoringSet body = null);
=======
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> PutCalibrationsCalibrationIdAsyncWithHttpInfo (string calibrationId, Calibration body = null);
        /// <summary>
        /// Update an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        System.Threading.Tasks.Task<Evaluation> PutConversationsConversationIdEvaluationsEvaluationIdAsync (string conversationId, string evaluationId, Evaluation body = null, string expand = null);

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Update an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of EvaluatorActivityEntityListing</returns>
        System.Threading.Tasks.Task<EvaluatorActivityEntityListing> QualityEvaluatorsActivityGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null);
=======
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> PutConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null);
        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EvaluationForm</returns>
        System.Threading.Tasks.Task<EvaluationForm> PutFormsFormIdAsync (string formId, EvaluationForm body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        /// <summary>
        /// Update an evaluation form.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of ApiResponse (EvaluatorActivityEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluatorActivityEntityListing>> QualityEvaluatorsActivityGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null);
=======
        /// <param name="formId">Form ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> PutFormsFormIdAsyncWithHttpInfo (string formId, EvaluationForm body = null);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class QualityApi : IQualityApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="QualityApi"/> class.
        /// </summary>
        /// <returns></returns>
        public QualityApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QualityApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public QualityApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Delete a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. (optional, default to 5000)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>List&lt;Recording&gt;</returns>
        public List<Recording> ConversationsConversationidRecordingsGet (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
             ApiResponse<List<Recording>> localVarResponse = ConversationsConversationidRecordingsGetWithHttpInfo(conversationId, maxWaitMs, formatId);
=======
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Calibration</returns>
        public Calibration DeleteCalibrationsCalibrationId (string calibrationId, string calibratorId)
        {
             ApiResponse<Calibration> localVarResponse = DeleteCalibrationsCalibrationIdWithHttpInfo(calibrationId, calibratorId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. (optional, default to 5000)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>ApiResponse of List&lt;Recording&gt;</returns>
        public ApiResponse< List<Recording> > ConversationsConversationidRecordingsGetWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->ConversationsConversationidRecordingsGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/recordings";
=======
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > DeleteCalibrationsCalibrationIdWithHttpInfo (string calibrationId, string calibratorId)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->DeleteCalibrationsCalibrationId");
            // verify the required parameter 'calibratorId' is set
            if (calibratorId == null)
                throw new ApiException(400, "Missing required parameter 'calibratorId' when calling QualityApi->DeleteCalibrationsCalibrationId");

            var localVarPath = "/api/v2/quality/calibrations/{calibrationId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (maxWaitMs != null) localVarQueryParams.Add("maxWaitMs", Configuration.ApiClient.ParameterToString(maxWaitMs)); // query parameter
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
=======
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Recording>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Recording>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Recording>)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteCalibrationsCalibrationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCalibrationsCalibrationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Delete a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. (optional, default to 5000)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>Task of List&lt;Recording&gt;</returns>
        public async System.Threading.Tasks.Task<List<Recording>> ConversationsConversationidRecordingsGetAsync (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
             ApiResponse<List<Recording>> localVarResponse = await ConversationsConversationidRecordingsGetAsyncWithHttpInfo(conversationId, maxWaitMs, formatId);
=======
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> DeleteCalibrationsCalibrationIdAsync (string calibrationId, string calibratorId)
        {
             ApiResponse<Calibration> localVarResponse = await DeleteCalibrationsCalibrationIdAsyncWithHttpInfo(calibrationId, calibratorId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. (optional, default to 5000)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>Task of ApiResponse (List&lt;Recording&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Recording>>> ConversationsConversationidRecordingsGetAsyncWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->ConversationsConversationidRecordingsGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/recordings";
=======
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> DeleteCalibrationsCalibrationIdAsyncWithHttpInfo (string calibrationId, string calibratorId)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->DeleteCalibrationsCalibrationId");
            // verify the required parameter 'calibratorId' is set
            if (calibratorId == null)
                throw new ApiException(400, "Missing required parameter 'calibratorId' when calling QualityApi->DeleteCalibrationsCalibrationId");

            var localVarPath = "/api/v2/quality/calibrations/{calibrationId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (maxWaitMs != null) localVarQueryParams.Add("maxWaitMs", Configuration.ApiClient.ParameterToString(maxWaitMs)); // query parameter
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
=======
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Recording>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Recording>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Recording>)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteCalibrationsCalibrationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteCalibrationsCalibrationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns></returns>
        public void ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete (string conversationId, string recordingId, string annotationId)
        {
             ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDeleteWithHttpInfo(conversationId, recordingId, annotationId);
        }

        /// <summary>
        /// Delete annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDeleteWithHttpInfo (string conversationId, string recordingId, string annotationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete");

            var localVarPath = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
=======
        /// Delete an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        public Evaluation DeleteConversationsConversationIdEvaluationsEvaluationId (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = DeleteConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo(conversationId, evaluationId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > DeleteConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->DeleteConversationsConversationIdEvaluationsEvaluationId");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->DeleteConversationsConversationIdEvaluationsEvaluationId");

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
<<<<<<< HEAD
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) localVarPathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter
=======
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDeleteAsync (string conversationId, string recordingId, string annotationId)
        {
             await ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDeleteAsyncWithHttpInfo(conversationId, recordingId, annotationId);
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationsConversationIdEvaluationsEvaluationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationsConversationIdEvaluationsEvaluationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        /// <summary>
        /// Delete an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        public async System.Threading.Tasks.Task<Evaluation> DeleteConversationsConversationIdEvaluationsEvaluationIdAsync (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = await DeleteConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo(conversationId, evaluationId, expand);
             return localVarResponse.Data;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
        /// Delete annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDeleteAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete");

            var localVarPath = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
=======
        /// Delete an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> DeleteConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->DeleteConversationsConversationIdEvaluationsEvaluationId");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->DeleteConversationsConversationIdEvaluationsEvaluationId");

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
<<<<<<< HEAD
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) localVarPathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter
=======
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
<<<<<<< HEAD

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationsConversationIdEvaluationsEvaluationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationsConversationIdEvaluationsEvaluationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
<<<<<<< HEAD
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Get annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Annotation</returns>
        public Annotation ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet (string conversationId, string recordingId, string annotationId)
        {
             ApiResponse<Annotation> localVarResponse = ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGetWithHttpInfo(conversationId, recordingId, annotationId);
=======
        }

        /// <summary>
        /// Delete an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>string</returns>
        public string DeleteFormsFormId (string formId)
        {
             ApiResponse<string> localVarResponse = DeleteFormsFormIdWithHttpInfo(formId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>ApiResponse of Annotation</returns>
        public ApiResponse< Annotation > ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGetWithHttpInfo (string conversationId, string recordingId, string annotationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
=======
        /// Delete an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteFormsFormIdWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->DeleteFormsFormId");

            var localVarPath = "/api/v2/quality/forms/{formId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) localVarPathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter
=======
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteFormsFormId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteFormsFormId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of Annotation</returns>
        public async System.Threading.Tasks.Task<Annotation> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGetAsync (string conversationId, string recordingId, string annotationId)
        {
             ApiResponse<Annotation> localVarResponse = await ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGetAsyncWithHttpInfo(conversationId, recordingId, annotationId);
=======
        /// Delete an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteFormsFormIdAsync (string formId)
        {
             ApiResponse<string> localVarResponse = await DeleteFormsFormIdAsyncWithHttpInfo(formId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Get annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Annotation>> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGetAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
=======
        /// Delete an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteFormsFormIdAsyncWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->DeleteFormsFormId");

            var localVarPath = "/api/v2/quality/forms/{formId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) localVarPathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter
=======
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)));
=======
                throw new ApiException (localVarStatusCode, "Error calling DeleteFormsFormId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteFormsFormId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>Annotation</returns>
        public Annotation ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut (string conversationId, string recordingId, string annotationId, Annotation body = null)
        {
             ApiResponse<Annotation> localVarResponse = ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPutWithHttpInfo(conversationId, recordingId, annotationId, body);
=======
        /// Gets a list of Agent Activities Including the number of evaluations and average evaluation score
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>AgentActivityEntityListing</returns>
        public AgentActivityEntityListing GetAgentsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {
             ApiResponse<AgentActivityEntityListing> localVarResponse = GetAgentsActivityWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, agentUserId, evaluatorUserId, name, group);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Update annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>ApiResponse of Annotation</returns>
        public ApiResponse< Annotation > ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPutWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut");

            var localVarPath = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
=======
        /// Gets a list of Agent Activities Including the number of evaluations and average evaluation score
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>ApiResponse of AgentActivityEntityListing</returns>
        public ApiResponse< AgentActivityEntityListing > GetAgentsActivityWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {

            var localVarPath = "/api/v2/quality/agents/activity";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) localVarPathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (agentUserId != null) localVarQueryParams.Add("agentUserId", Configuration.ApiClient.ParameterToString(agentUserId)); // query parameter
            if (evaluatorUserId != null) localVarQueryParams.Add("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (group != null) localVarQueryParams.Add("group", Configuration.ApiClient.ParameterToString(group)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetAgentsActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAgentsActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentActivityEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AgentActivityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentActivityEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>Task of Annotation</returns>
        public async System.Threading.Tasks.Task<Annotation> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPutAsync (string conversationId, string recordingId, string annotationId, Annotation body = null)
        {
             ApiResponse<Annotation> localVarResponse = await ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPutAsyncWithHttpInfo(conversationId, recordingId, annotationId, body);
=======
        /// Gets a list of Agent Activities Including the number of evaluations and average evaluation score
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of AgentActivityEntityListing</returns>
        public async System.Threading.Tasks.Task<AgentActivityEntityListing> GetAgentsActivityAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {
             ApiResponse<AgentActivityEntityListing> localVarResponse = await GetAgentsActivityAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, agentUserId, evaluatorUserId, name, group);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Update annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Annotation>> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPutAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut");

            var localVarPath = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
=======
        /// Gets a list of Agent Activities Including the number of evaluations and average evaluation score
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of ApiResponse (AgentActivityEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AgentActivityEntityListing>> GetAgentsActivityAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {

            var localVarPath = "/api/v2/quality/agents/activity";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) localVarPathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (agentUserId != null) localVarQueryParams.Add("agentUserId", Configuration.ApiClient.ParameterToString(agentUserId)); // query parameter
            if (evaluatorUserId != null) localVarQueryParams.Add("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (group != null) localVarQueryParams.Add("group", Configuration.ApiClient.ParameterToString(group)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetAgentsActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetAgentsActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentActivityEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AgentActivityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentActivityEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get annotations for recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>List&lt;Annotation&gt;</returns>
        public List<Annotation> ConversationsConversationidRecordingsRecordingidAnnotationsGet (string conversationId, string recordingId)
        {
             ApiResponse<List<Annotation>> localVarResponse = ConversationsConversationidRecordingsRecordingidAnnotationsGetWithHttpInfo(conversationId, recordingId);
=======
        /// Get the list of calibrations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <returns>CalibrationEntityListing</returns>
        public CalibrationEntityListing GetCalibrations (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null)
        {
             ApiResponse<CalibrationEntityListing> localVarResponse = GetCalibrationsWithHttpInfo(calibratorId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, conversationId, startTime, endTime);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get annotations for recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>ApiResponse of List&lt;Annotation&gt;</returns>
        public ApiResponse< List<Annotation> > ConversationsConversationidRecordingsRecordingidAnnotationsGetWithHttpInfo (string conversationId, string recordingId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsGet");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations";
=======
        /// Get the list of calibrations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <returns>ApiResponse of CalibrationEntityListing</returns>
        public ApiResponse< CalibrationEntityListing > GetCalibrationsWithHttpInfo (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null)
        {
            // verify the required parameter 'calibratorId' is set
            if (calibratorId == null)
                throw new ApiException(400, "Missing required parameter 'calibratorId' when calling QualityApi->GetCalibrations");

            var localVarPath = "/api/v2/quality/calibrations";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Annotation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Annotation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Annotation>)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetCalibrations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCalibrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CalibrationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CalibrationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CalibrationEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get annotations for recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of List&lt;Annotation&gt;</returns>
        public async System.Threading.Tasks.Task<List<Annotation>> ConversationsConversationidRecordingsRecordingidAnnotationsGetAsync (string conversationId, string recordingId)
        {
             ApiResponse<List<Annotation>> localVarResponse = await ConversationsConversationidRecordingsRecordingidAnnotationsGetAsyncWithHttpInfo(conversationId, recordingId);
=======
        /// Get the list of calibrations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <returns>Task of CalibrationEntityListing</returns>
        public async System.Threading.Tasks.Task<CalibrationEntityListing> GetCalibrationsAsync (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null)
        {
             ApiResponse<CalibrationEntityListing> localVarResponse = await GetCalibrationsAsyncWithHttpInfo(calibratorId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, conversationId, startTime, endTime);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Get annotations for recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of ApiResponse (List&lt;Annotation&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Annotation>>> ConversationsConversationidRecordingsRecordingidAnnotationsGetAsyncWithHttpInfo (string conversationId, string recordingId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsGet");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations";
=======
        /// Get the list of calibrations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <returns>Task of ApiResponse (CalibrationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CalibrationEntityListing>> GetCalibrationsAsyncWithHttpInfo (string calibratorId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null)
        {
            // verify the required parameter 'calibratorId' is set
            if (calibratorId == null)
                throw new ApiException(400, "Missing required parameter 'calibratorId' when calling QualityApi->GetCalibrations");

            var localVarPath = "/api/v2/quality/calibrations";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Annotation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Annotation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Annotation>)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetCalibrations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCalibrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CalibrationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CalibrationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CalibrationEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Create annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>Annotation</returns>
        public Annotation ConversationsConversationidRecordingsRecordingidAnnotationsPost (string conversationId, string recordingId, Annotation body = null)
        {
             ApiResponse<Annotation> localVarResponse = ConversationsConversationidRecordingsRecordingidAnnotationsPostWithHttpInfo(conversationId, recordingId, body);
=======
        /// Get a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Calibration</returns>
        public Calibration GetCalibrationsCalibrationId (string calibrationId, string calibratorId)
        {
             ApiResponse<Calibration> localVarResponse = GetCalibrationsCalibrationIdWithHttpInfo(calibrationId, calibratorId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Create annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>ApiResponse of Annotation</returns>
        public ApiResponse< Annotation > ConversationsConversationidRecordingsRecordingidAnnotationsPostWithHttpInfo (string conversationId, string recordingId, Annotation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsPost");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsPost");

            var localVarPath = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations";
=======
        /// Get a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > GetCalibrationsCalibrationIdWithHttpInfo (string calibrationId, string calibratorId)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->GetCalibrationsCalibrationId");
            // verify the required parameter 'calibratorId' is set
            if (calibratorId == null)
                throw new ApiException(400, "Missing required parameter 'calibratorId' when calling QualityApi->GetCalibrationsCalibrationId");

            var localVarPath = "/api/v2/quality/calibrations/{calibrationId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetCalibrationsCalibrationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCalibrationsCalibrationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Create annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>Task of Annotation</returns>
        public async System.Threading.Tasks.Task<Annotation> ConversationsConversationidRecordingsRecordingidAnnotationsPostAsync (string conversationId, string recordingId, Annotation body = null)
        {
             ApiResponse<Annotation> localVarResponse = await ConversationsConversationidRecordingsRecordingidAnnotationsPostAsyncWithHttpInfo(conversationId, recordingId, body);
=======
        /// Get a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> GetCalibrationsCalibrationIdAsync (string calibrationId, string calibratorId)
        {
             ApiResponse<Calibration> localVarResponse = await GetCalibrationsCalibrationIdAsyncWithHttpInfo(calibrationId, calibratorId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Create annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Annotation>> ConversationsConversationidRecordingsRecordingidAnnotationsPostAsyncWithHttpInfo (string conversationId, string recordingId, Annotation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsPost");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidAnnotationsPost");

            var localVarPath = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations";
=======
        /// Get a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> GetCalibrationsCalibrationIdAsyncWithHttpInfo (string calibrationId, string calibratorId)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->GetCalibrationsCalibrationId");
            // verify the required parameter 'calibratorId' is set
            if (calibratorId == null)
                throw new ApiException(400, "Missing required parameter 'calibratorId' when calling QualityApi->GetCalibrationsCalibrationId");

            var localVarPath = "/api/v2/quality/calibrations/{calibrationId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetCalibrationsCalibrationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetCalibrationsCalibrationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Gets a specific recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for completion. (optional)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns></returns>
        public void ConversationsConversationidRecordingsRecordingidGet (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null)
        {
             ConversationsConversationidRecordingsRecordingidGetWithHttpInfo(conversationId, recordingId, maxWaitMs, formatId, download, fileName);
        }

        /// <summary>
        /// Gets a specific recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for completion. (optional)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ConversationsConversationidRecordingsRecordingidGetWithHttpInfo (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidGet");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/recordings/{recordingId}";
=======
        /// Get audits for conversation or recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>QualityAuditPage</returns>
        public QualityAuditPage GetConversationsConversationIdAudits (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null)
        {
             ApiResponse<QualityAuditPage> localVarResponse = GetConversationsConversationIdAuditsWithHttpInfo(conversationId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, recordingId, entityType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get audits for conversation or recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>ApiResponse of QualityAuditPage</returns>
        public ApiResponse< QualityAuditPage > GetConversationsConversationIdAuditsWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->GetConversationsConversationIdAudits");

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/audits";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
<<<<<<< HEAD
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (maxWaitMs != null) localVarQueryParams.Add("maxWaitMs", Configuration.ApiClient.ParameterToString(maxWaitMs)); // query parameter
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
            if (download != null) localVarQueryParams.Add("download", Configuration.ApiClient.ParameterToString(download)); // query parameter
            if (fileName != null) localVarQueryParams.Add("fileName", Configuration.ApiClient.ParameterToString(fileName)); // query parameter
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (recordingId != null) localVarQueryParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // query parameter
            if (entityType != null) localVarQueryParams.Add("entityType", Configuration.ApiClient.ParameterToString(entityType)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdAudits: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QualityAuditPage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QualityAuditPage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QualityAuditPage)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Gets a specific recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for completion. (optional)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConversationsConversationidRecordingsRecordingidGetAsync (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null)
        {
             await ConversationsConversationidRecordingsRecordingidGetAsyncWithHttpInfo(conversationId, recordingId, maxWaitMs, formatId, download, fileName);
=======
        /// Get audits for conversation or recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>Task of QualityAuditPage</returns>
        public async System.Threading.Tasks.Task<QualityAuditPage> GetConversationsConversationIdAuditsAsync (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null)
        {
             ApiResponse<QualityAuditPage> localVarResponse = await GetConversationsConversationIdAuditsAsyncWithHttpInfo(conversationId, pageSize, pageNumber, sortBy, expand, nextPage, previousPage, recordingId, entityType);
             return localVarResponse.Data;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
        /// Gets a specific recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for completion. (optional)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidRecordingsRecordingidGetAsyncWithHttpInfo (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidGet");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidGet");

            var localVarPath = "/api/v1/conversations/{conversationId}/recordings/{recordingId}";
=======
        /// Get audits for conversation or recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>Task of ApiResponse (QualityAuditPage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QualityAuditPage>> GetConversationsConversationIdAuditsAsyncWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string recordingId = null, string entityType = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->GetConversationsConversationIdAudits");

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/audits";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
<<<<<<< HEAD
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (maxWaitMs != null) localVarQueryParams.Add("maxWaitMs", Configuration.ApiClient.ParameterToString(maxWaitMs)); // query parameter
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
            if (download != null) localVarQueryParams.Add("download", Configuration.ApiClient.ParameterToString(download)); // query parameter
            if (fileName != null) localVarQueryParams.Add("fileName", Configuration.ApiClient.ParameterToString(fileName)); // query parameter
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (recordingId != null) localVarQueryParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // query parameter
            if (entityType != null) localVarQueryParams.Add("entityType", Configuration.ApiClient.ParameterToString(entityType)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

=======
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdAudits: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdAudits: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QualityAuditPage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QualityAuditPage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QualityAuditPage)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
<<<<<<< HEAD
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays&#x3D;10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated. (optional)</param>
        /// <returns></returns>
        public void ConversationsConversationidRecordingsRecordingidPut (string conversationId, string recordingId, Recording body, int? restoreDays = null)
        {
             ConversationsConversationidRecordingsRecordingidPutWithHttpInfo(conversationId, recordingId, body, restoreDays);
        }

        /// <summary>
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays&#x3D;10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> ConversationsConversationidRecordingsRecordingidPutWithHttpInfo (string conversationId, string recordingId, Recording body, int? restoreDays = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidPut");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidPut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->ConversationsConversationidRecordingsRecordingidPut");

            var localVarPath = "/api/v1/conversations/{conversationId}/recordings/{recordingId}";
=======
        /// Get an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>Evaluation</returns>
        public Evaluation GetConversationsConversationIdEvaluationsEvaluationId (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = GetConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo(conversationId, evaluationId, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > GetConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->GetConversationsConversationIdEvaluationsEvaluationId");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->GetConversationsConversationIdEvaluationsEvaluationId");

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
<<<<<<< HEAD
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (restoreDays != null) localVarQueryParams.Add("restoreDays", Configuration.ApiClient.ParameterToString(restoreDays)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays&#x3D;10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated. (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConversationsConversationidRecordingsRecordingidPutAsync (string conversationId, string recordingId, Recording body, int? restoreDays = null)
        {
             await ConversationsConversationidRecordingsRecordingidPutAsyncWithHttpInfo(conversationId, recordingId, body, restoreDays);
=======
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdEvaluationsEvaluationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdEvaluationsEvaluationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        /// <summary>
        /// Get an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>Task of Evaluation</returns>
        public async System.Threading.Tasks.Task<Evaluation> GetConversationsConversationIdEvaluationsEvaluationIdAsync (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = await GetConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo(conversationId, evaluationId, expand);
             return localVarResponse.Data;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

        }

        /// <summary>
<<<<<<< HEAD
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays&#x3D;10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidRecordingsRecordingidPutAsyncWithHttpInfo (string conversationId, string recordingId, Recording body, int? restoreDays = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidPut");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->ConversationsConversationidRecordingsRecordingidPut");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->ConversationsConversationidRecordingsRecordingidPut");

            var localVarPath = "/api/v1/conversations/{conversationId}/recordings/{recordingId}";
=======
        /// Get an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> GetConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->GetConversationsConversationIdEvaluationsEvaluationId");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->GetConversationsConversationIdEvaluationsEvaluationId");

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
<<<<<<< HEAD
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (restoreDays != null) localVarQueryParams.Add("restoreDays", Configuration.ApiClient.ParameterToString(restoreDays)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdEvaluationsEvaluationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationsConversationIdEvaluationsEvaluationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
<<<<<<< HEAD
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        }

        /// <summary>
        /// Queries Evaluations and returns a paged list Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
<<<<<<< HEAD
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>AgentActivityEntityListing</returns>
        public AgentActivityEntityListing QualityAgentsActivityGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {
             ApiResponse<AgentActivityEntityListing> localVarResponse = QualityAgentsActivityGetWithHttpInfo(pageSize, pageNumber, sortBy, expand, startTime, endTime, agentUserId, evaluatorUserId, name, group);
=======
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>EvaluationEntityListing</returns>
        public EvaluationEntityListing GetEvaluationsQuery (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
        {
             ApiResponse<EvaluationEntityListing> localVarResponse = GetEvaluationsQueryWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, conversationId, agentUserId, evaluatorUserId, queueId, startTime, endTime, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Queries Evaluations and returns a paged list Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
<<<<<<< HEAD
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>ApiResponse of AgentActivityEntityListing</returns>
        public ApiResponse< AgentActivityEntityListing > QualityAgentsActivityGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {

            var localVarPath = "/api/v1/quality/agents/activity";
=======
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        public ApiResponse< EvaluationEntityListing > GetEvaluationsQueryWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
        {

            var localVarPath = "/api/v2/quality/evaluations/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
<<<<<<< HEAD
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (agentUserId != null) localVarQueryParams.Add("agentUserId", Configuration.ApiClient.ParameterToString(agentUserId)); // query parameter
            if (evaluatorUserId != null) localVarQueryParams.Add("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (group != null) localVarQueryParams.Add("group", Configuration.ApiClient.ParameterToString(group)); // query parameter
=======
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            if (agentUserId != null) localVarQueryParams.Add("agentUserId", Configuration.ApiClient.ParameterToString(agentUserId)); // query parameter
            if (evaluatorUserId != null) localVarQueryParams.Add("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)); // query parameter
            if (queueId != null) localVarQueryParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (evaluationState != null) localVarQueryParams.Add("evaluationState", Configuration.ApiClient.ParameterToString(evaluationState)); // query parameter
            if (isReleased != null) localVarQueryParams.Add("isReleased", Configuration.ApiClient.ParameterToString(isReleased)); // query parameter
            if (agentHasRead != null) localVarQueryParams.Add("agentHasRead", Configuration.ApiClient.ParameterToString(agentHasRead)); // query parameter
            if (expandAnswerTotalScores != null) localVarQueryParams.Add("expandAnswerTotalScores", Configuration.ApiClient.ParameterToString(expandAnswerTotalScores)); // query parameter
            if (maximum != null) localVarQueryParams.Add("maximum", Configuration.ApiClient.ParameterToString(maximum)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityAgentsActivityGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityAgentsActivityGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentActivityEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AgentActivityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentActivityEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetEvaluationsQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEvaluationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Queries Evaluations and returns a paged list Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
<<<<<<< HEAD
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of AgentActivityEntityListing</returns>
        public async System.Threading.Tasks.Task<AgentActivityEntityListing> QualityAgentsActivityGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {
             ApiResponse<AgentActivityEntityListing> localVarResponse = await QualityAgentsActivityGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, startTime, endTime, agentUserId, evaluatorUserId, name, group);
=======
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationEntityListing> GetEvaluationsQueryAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
        {
             ApiResponse<EvaluationEntityListing> localVarResponse = await GetEvaluationsQueryAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, conversationId, agentUserId, evaluatorUserId, queueId, startTime, endTime, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Queries Evaluations and returns a paged list Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
<<<<<<< HEAD
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="agentUserId">user id of agent requested (optional)</param>
        /// <param name="evaluatorUserId">user id of the evaluator (optional)</param>
        /// <param name="name">name (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of ApiResponse (AgentActivityEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AgentActivityEntityListing>> QualityAgentsActivityGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {

            var localVarPath = "/api/v1/quality/agents/activity";
=======
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> GetEvaluationsQueryAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
        {

            var localVarPath = "/api/v2/quality/evaluations/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
<<<<<<< HEAD
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (agentUserId != null) localVarQueryParams.Add("agentUserId", Configuration.ApiClient.ParameterToString(agentUserId)); // query parameter
            if (evaluatorUserId != null) localVarQueryParams.Add("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (group != null) localVarQueryParams.Add("group", Configuration.ApiClient.ParameterToString(group)); // query parameter
=======
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            if (agentUserId != null) localVarQueryParams.Add("agentUserId", Configuration.ApiClient.ParameterToString(agentUserId)); // query parameter
            if (evaluatorUserId != null) localVarQueryParams.Add("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)); // query parameter
            if (queueId != null) localVarQueryParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (evaluationState != null) localVarQueryParams.Add("evaluationState", Configuration.ApiClient.ParameterToString(evaluationState)); // query parameter
            if (isReleased != null) localVarQueryParams.Add("isReleased", Configuration.ApiClient.ParameterToString(isReleased)); // query parameter
            if (agentHasRead != null) localVarQueryParams.Add("agentHasRead", Configuration.ApiClient.ParameterToString(agentHasRead)); // query parameter
            if (expandAnswerTotalScores != null) localVarQueryParams.Add("expandAnswerTotalScores", Configuration.ApiClient.ParameterToString(expandAnswerTotalScores)); // query parameter
            if (maximum != null) localVarQueryParams.Add("maximum", Configuration.ApiClient.ParameterToString(maximum)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityAgentsActivityGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityAgentsActivityGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentActivityEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AgentActivityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentActivityEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetEvaluationsQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEvaluationsQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Calibration</returns>
        public Calibration QualityCalibrationsCalibrationidDelete (string calibrationId, string calibratorId = null)
        {
             ApiResponse<Calibration> localVarResponse = QualityCalibrationsCalibrationidDeleteWithHttpInfo(calibrationId, calibratorId);
=======
        /// Get an evaluator activity 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>EvaluatorActivityEntityListing</returns>
        public EvaluatorActivityEntityListing GetEvaluatorsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)
        {
             ApiResponse<EvaluatorActivityEntityListing> localVarResponse = GetEvaluatorsActivityWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, name, permission, group);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > QualityCalibrationsCalibrationidDeleteWithHttpInfo (string calibrationId, string calibratorId = null)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->QualityCalibrationsCalibrationidDelete");

            var localVarPath = "/api/v1/quality/calibrations/{calibrationId}";
=======
        /// Get an evaluator activity 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>ApiResponse of EvaluatorActivityEntityListing</returns>
        public ApiResponse< EvaluatorActivityEntityListing > GetEvaluatorsActivityWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)
        {

            var localVarPath = "/api/v2/quality/evaluators/activity";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (permission != null) localVarQueryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            if (group != null) localVarQueryParams.Add("group", Configuration.ApiClient.ParameterToString(group)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetEvaluatorsActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEvaluatorsActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluatorActivityEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluatorActivityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluatorActivityEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> QualityCalibrationsCalibrationidDeleteAsync (string calibrationId, string calibratorId = null)
        {
             ApiResponse<Calibration> localVarResponse = await QualityCalibrationsCalibrationidDeleteAsyncWithHttpInfo(calibrationId, calibratorId);
=======
        /// Get an evaluator activity 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of EvaluatorActivityEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluatorActivityEntityListing> GetEvaluatorsActivityAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)
        {
             ApiResponse<EvaluatorActivityEntityListing> localVarResponse = await GetEvaluatorsActivityAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, startTime, endTime, name, permission, group);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Delete a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> QualityCalibrationsCalibrationidDeleteAsyncWithHttpInfo (string calibrationId, string calibratorId = null)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->QualityCalibrationsCalibrationidDelete");

            var localVarPath = "/api/v1/quality/calibrations/{calibrationId}";
=======
        /// Get an evaluator activity 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of ApiResponse (EvaluatorActivityEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluatorActivityEntityListing>> GetEvaluatorsActivityAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string nextPage = null, string previousPage = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)
        {

            var localVarPath = "/api/v2/quality/evaluators/activity";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (permission != null) localVarQueryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            if (group != null) localVarQueryParams.Add("group", Configuration.ApiClient.ParameterToString(group)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetEvaluatorsActivity: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetEvaluatorsActivity: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluatorActivityEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluatorActivityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluatorActivityEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Calibration</returns>
        public Calibration QualityCalibrationsCalibrationidGet (string calibrationId, string calibratorId = null)
        {
             ApiResponse<Calibration> localVarResponse = QualityCalibrationsCalibrationidGetWithHttpInfo(calibrationId, calibratorId);
=======
        /// Get the list of evaluation forms 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>EvaluationFormEntityListing</returns>
        public EvaluationFormEntityListing GetForms (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = GetFormsWithHttpInfo(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > QualityCalibrationsCalibrationidGetWithHttpInfo (string calibrationId, string calibratorId = null)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->QualityCalibrationsCalibrationidGet");

            var localVarPath = "/api/v1/quality/calibrations/{calibrationId}";
=======
        /// Get the list of evaluation forms 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        public ApiResponse< EvaluationFormEntityListing > GetFormsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null)
        {

            var localVarPath = "/api/v2/quality/forms";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetForms: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetForms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> QualityCalibrationsCalibrationidGetAsync (string calibrationId, string calibratorId = null)
        {
             ApiResponse<Calibration> localVarResponse = await QualityCalibrationsCalibrationidGetAsyncWithHttpInfo(calibrationId, calibratorId);
=======
        /// Get the list of evaluation forms 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationFormEntityListing> GetFormsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = await GetFormsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, nextPage, previousPage, expand, name);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Get a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> QualityCalibrationsCalibrationidGetAsyncWithHttpInfo (string calibrationId, string calibratorId = null)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->QualityCalibrationsCalibrationidGet");

            var localVarPath = "/api/v1/quality/calibrations/{calibrationId}";
=======
        /// Get the list of evaluation forms 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="expand">Expand (optional)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetFormsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, string nextPage = null, string previousPage = null, string expand = null, string name = null)
        {

            var localVarPath = "/api/v2/quality/forms";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetForms: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetForms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Calibration</returns>
        public Calibration QualityCalibrationsCalibrationidPut (string calibrationId, Calibration body = null)
        {
             ApiResponse<Calibration> localVarResponse = QualityCalibrationsCalibrationidPutWithHttpInfo(calibrationId, body);
=======
        /// Get an evaluation form 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationForm</returns>
        public EvaluationForm GetFormsFormId (string formId)
        {
             ApiResponse<EvaluationForm> localVarResponse = GetFormsFormIdWithHttpInfo(formId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > QualityCalibrationsCalibrationidPutWithHttpInfo (string calibrationId, Calibration body = null)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->QualityCalibrationsCalibrationidPut");

            var localVarPath = "/api/v1/quality/calibrations/{calibrationId}";
=======
        /// Get an evaluation form 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > GetFormsFormIdWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetFormsFormId");

            var localVarPath = "/api/v2/quality/forms/{formId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetFormsFormId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFormsFormId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> QualityCalibrationsCalibrationidPutAsync (string calibrationId, Calibration body = null)
        {
             ApiResponse<Calibration> localVarResponse = await QualityCalibrationsCalibrationidPutAsyncWithHttpInfo(calibrationId, body);
=======
        /// Get an evaluation form 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> GetFormsFormIdAsync (string formId)
        {
             ApiResponse<EvaluationForm> localVarResponse = await GetFormsFormIdAsyncWithHttpInfo(formId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> QualityCalibrationsCalibrationidPutAsyncWithHttpInfo (string calibrationId, Calibration body = null)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->QualityCalibrationsCalibrationidPut");

            var localVarPath = "/api/v1/quality/calibrations/{calibrationId}";
=======
        /// Get an evaluation form 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> GetFormsFormIdAsyncWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetFormsFormId");

            var localVarPath = "/api/v2/quality/forms/{formId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetFormsFormId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFormsFormId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get the list of calibrations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="calibratorId">user id of calibrator (optional)</param>
        /// <returns>CalibrationEntityListing</returns>
        public CalibrationEntityListing QualityCalibrationsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null)
        {
             ApiResponse<CalibrationEntityListing> localVarResponse = QualityCalibrationsGetWithHttpInfo(pageSize, pageNumber, sortBy, expand, conversationId, startTime, endTime, calibratorId);
=======
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>EvaluationFormEntityListing</returns>
        public EvaluationFormEntityListing GetFormsFormIdVersions (string formId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = GetFormsFormIdVersionsWithHttpInfo(formId, pageSize, pageNumber);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Get the list of calibrations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="calibratorId">user id of calibrator (optional)</param>
        /// <returns>ApiResponse of CalibrationEntityListing</returns>
        public ApiResponse< CalibrationEntityListing > QualityCalibrationsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null)
        {

            var localVarPath = "/api/v1/quality/calibrations";
=======
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        public ApiResponse< EvaluationFormEntityListing > GetFormsFormIdVersionsWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetFormsFormIdVersions");

            var localVarPath = "/api/v2/quality/forms/{formId}/versions";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
=======
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CalibrationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CalibrationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CalibrationEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetFormsFormIdVersions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFormsFormIdVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Get the list of calibrations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="calibratorId">user id of calibrator (optional)</param>
        /// <returns>Task of CalibrationEntityListing</returns>
        public async System.Threading.Tasks.Task<CalibrationEntityListing> QualityCalibrationsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null)
        {
             ApiResponse<CalibrationEntityListing> localVarResponse = await QualityCalibrationsGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, conversationId, startTime, endTime, calibratorId);
=======
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationFormEntityListing> GetFormsFormIdVersionsAsync (string formId, int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = await GetFormsFormIdVersionsAsyncWithHttpInfo(formId, pageSize, pageNumber);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Get the list of calibrations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="conversationId">conversation id (optional)</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="calibratorId">user id of calibrator (optional)</param>
        /// <returns>Task of ApiResponse (CalibrationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CalibrationEntityListing>> QualityCalibrationsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null)
        {

            var localVarPath = "/api/v1/quality/calibrations";
=======
        /// Gets all the revisions for a specific evaluation. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetFormsFormIdVersionsAsyncWithHttpInfo (string formId, int? pageSize = null, int? pageNumber = null)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetFormsFormIdVersions");

            var localVarPath = "/api/v2/quality/forms/{formId}/versions";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
=======
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CalibrationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CalibrationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CalibrationEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetFormsFormIdVersions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetFormsFormIdVersions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Create a calibration 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Calibration</returns>
        public Calibration QualityCalibrationsPost (Calibration body = null, string expand = null)
        {
             ApiResponse<Calibration> localVarResponse = QualityCalibrationsPostWithHttpInfo(body, expand);
=======
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>EvaluationFormEntityListing</returns>
        public EvaluationFormEntityListing GetPublishedforms (int? pageSize = null, int? pageNumber = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = GetPublishedformsWithHttpInfo(pageSize, pageNumber, name);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Create a calibration 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > QualityCalibrationsPostWithHttpInfo (Calibration body = null, string expand = null)
        {

            var localVarPath = "/api/v1/quality/calibrations";
=======
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>ApiResponse of EvaluationFormEntityListing</returns>
        public ApiResponse< EvaluationFormEntityListing > GetPublishedformsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null)
        {

            var localVarPath = "/api/v2/quality/publishedforms";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedforms: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedforms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Create a calibration 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> QualityCalibrationsPostAsync (Calibration body = null, string expand = null)
        {
             ApiResponse<Calibration> localVarResponse = await QualityCalibrationsPostAsyncWithHttpInfo(body, expand);
=======
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of EvaluationFormEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationFormEntityListing> GetPublishedformsAsync (int? pageSize = null, int? pageNumber = null, string name = null)
        {
             ApiResponse<EvaluationFormEntityListing> localVarResponse = await GetPublishedformsAsyncWithHttpInfo(pageSize, pageNumber, name);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Create a calibration 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> QualityCalibrationsPostAsyncWithHttpInfo (Calibration body = null, string expand = null)
        {

            var localVarPath = "/api/v1/quality/calibrations";
=======
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <param name="name">Name (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationFormEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationFormEntityListing>> GetPublishedformsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string name = null)
        {

            var localVarPath = "/api/v2/quality/publishedforms";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
=======
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedforms: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedforms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationFormEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationFormEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationFormEntityListing)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>QualityAuditPage</returns>
        public QualityAuditPage QualityConversationsConversationidAuditsGet (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)
        {
             ApiResponse<QualityAuditPage> localVarResponse = QualityConversationsConversationidAuditsGetWithHttpInfo(conversationId, pageSize, pageNumber, sortBy, expand, recordingId, entityType);
=======
        /// <param name="formId">Form ID</param>
        /// <returns>EvaluationForm</returns>
        public EvaluationForm GetPublishedformsFormId (string formId)
        {
             ApiResponse<EvaluationForm> localVarResponse = GetPublishedformsFormIdWithHttpInfo(formId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>ApiResponse of QualityAuditPage</returns>
        public ApiResponse< QualityAuditPage > QualityConversationsConversationidAuditsGetWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->QualityConversationsConversationidAuditsGet");

            var localVarPath = "/api/v1/quality/conversations/{conversationId}/audits";
=======
        /// <param name="formId">Form ID</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > GetPublishedformsFormIdWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetPublishedformsFormId");

            var localVarPath = "/api/v2/quality/publishedforms/{formId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (recordingId != null) localVarQueryParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // query parameter
            if (entityType != null) localVarQueryParams.Add("entityType", Configuration.ApiClient.ParameterToString(entityType)); // query parameter
=======
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidAuditsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidAuditsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QualityAuditPage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QualityAuditPage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QualityAuditPage)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedformsFormId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedformsFormId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>Task of QualityAuditPage</returns>
        public async System.Threading.Tasks.Task<QualityAuditPage> QualityConversationsConversationidAuditsGetAsync (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)
        {
             ApiResponse<QualityAuditPage> localVarResponse = await QualityConversationsConversationidAuditsGetAsyncWithHttpInfo(conversationId, pageSize, pageNumber, sortBy, expand, recordingId, entityType);
=======
        /// <param name="formId">Form ID</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> GetPublishedformsFormIdAsync (string formId)
        {
             ApiResponse<EvaluationForm> localVarResponse = await GetPublishedformsFormIdAsyncWithHttpInfo(formId);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the published evaluation forms. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>Task of ApiResponse (QualityAuditPage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QualityAuditPage>> QualityConversationsConversationidAuditsGetAsyncWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->QualityConversationsConversationidAuditsGet");

            var localVarPath = "/api/v1/quality/conversations/{conversationId}/audits";
=======
        /// <param name="formId">Form ID</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> GetPublishedformsFormIdAsyncWithHttpInfo (string formId)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->GetPublishedformsFormId");

            var localVarPath = "/api/v2/quality/publishedforms/{formId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (recordingId != null) localVarQueryParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // query parameter
            if (entityType != null) localVarQueryParams.Add("entityType", Configuration.ApiClient.ParameterToString(entityType)); // query parameter
=======
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidAuditsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidAuditsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QualityAuditPage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QualityAuditPage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QualityAuditPage)));
=======
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedformsFormId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetPublishedformsFormId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        public Evaluation QualityConversationsConversationidEvaluationsEvaluationidDelete (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = QualityConversationsConversationidEvaluationsEvaluationidDeleteWithHttpInfo(conversationId, evaluationId, expand);
=======
        /// Create a calibration 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Calibration</returns>
        public Calibration PostCalibrations (Calibration body = null, string expand = null)
        {
             ApiResponse<Calibration> localVarResponse = PostCalibrationsWithHttpInfo(body, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > QualityConversationsConversationidEvaluationsEvaluationidDeleteWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidDelete");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidDelete");

            var localVarPath = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
=======
        /// Create a calibration 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > PostCalibrationsWithHttpInfo (Calibration body = null, string expand = null)
        {

            var localVarPath = "/api/v2/quality/calibrations";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostCalibrations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCalibrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Delete an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        public async System.Threading.Tasks.Task<Evaluation> QualityConversationsConversationidEvaluationsEvaluationidDeleteAsync (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = await QualityConversationsConversationidEvaluationsEvaluationidDeleteAsyncWithHttpInfo(conversationId, evaluationId, expand);
=======
        /// Create a calibration 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> PostCalibrationsAsync (Calibration body = null, string expand = null)
        {
             ApiResponse<Calibration> localVarResponse = await PostCalibrationsAsyncWithHttpInfo(body, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Delete an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> QualityConversationsConversationidEvaluationsEvaluationidDeleteAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidDelete");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidDelete");

            var localVarPath = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
=======
        /// Create a calibration 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> PostCalibrationsAsyncWithHttpInfo (Calibration body = null, string expand = null)
        {

            var localVarPath = "/api/v2/quality/calibrations";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostCalibrations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostCalibrations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Create an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
<<<<<<< HEAD
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
=======
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <returns>Evaluation</returns>
        public Evaluation PostConversationsConversationIdEvaluations (string conversationId, Evaluation body = null, string expand = null)
        {
<<<<<<< HEAD
             ApiResponse<Evaluation> localVarResponse = QualityConversationsConversationidEvaluationsEvaluationidGetWithHttpInfo(conversationId, evaluationId, expand);
=======
             ApiResponse<Evaluation> localVarResponse = PostConversationsConversationIdEvaluationsWithHttpInfo(conversationId, body, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
<<<<<<< HEAD
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
=======
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > PostConversationsConversationIdEvaluationsWithHttpInfo (string conversationId, Evaluation body = null, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidGet");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidGet");

            var localVarPath = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
=======
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->PostConversationsConversationIdEvaluations");

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/evaluations";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
<<<<<<< HEAD
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdEvaluations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdEvaluations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        /// <summary>
        /// Create an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
<<<<<<< HEAD
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
=======
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <returns>Task of Evaluation</returns>
        public async System.Threading.Tasks.Task<Evaluation> PostConversationsConversationIdEvaluationsAsync (string conversationId, Evaluation body = null, string expand = null)
        {
<<<<<<< HEAD
             ApiResponse<Evaluation> localVarResponse = await QualityConversationsConversationidEvaluationsEvaluationidGetAsyncWithHttpInfo(conversationId, evaluationId, expand);
=======
             ApiResponse<Evaluation> localVarResponse = await PostConversationsConversationIdEvaluationsAsyncWithHttpInfo(conversationId, body, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
<<<<<<< HEAD
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
=======
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> PostConversationsConversationIdEvaluationsAsyncWithHttpInfo (string conversationId, Evaluation body = null, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
<<<<<<< HEAD
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidGet");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidGet");

            var localVarPath = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
=======
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->PostConversationsConversationIdEvaluations");

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/evaluations";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
<<<<<<< HEAD
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
=======
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdEvaluations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationsConversationIdEvaluations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        /// <summary>
        /// Query for evaluation aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        public Evaluation QualityConversationsConversationidEvaluationsEvaluationidPut (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = QualityConversationsConversationidEvaluationsEvaluationidPutWithHttpInfo(conversationId, evaluationId, body, expand);
=======
        /// <param name="body">query (optional)</param>
        /// <returns>AggregateQueryResponse</returns>
        public AggregateQueryResponse PostEvaluationsAggregatesQuery (AggregationQuery body = null)
        {
             ApiResponse<AggregateQueryResponse> localVarResponse = PostEvaluationsAggregatesQueryWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query for evaluation aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > QualityConversationsConversationidEvaluationsEvaluationidPutWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidPut");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidPut");

            var localVarPath = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
=======
        /// <param name="body">query (optional)</param>
        /// <returns>ApiResponse of AggregateQueryResponse</returns>
        public ApiResponse< AggregateQueryResponse > PostEvaluationsAggregatesQueryWithHttpInfo (AggregationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/evaluations/aggregates/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostEvaluationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEvaluationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregateQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AggregateQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregateQueryResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Query for evaluation aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        public async System.Threading.Tasks.Task<Evaluation> QualityConversationsConversationidEvaluationsEvaluationidPutAsync (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = await QualityConversationsConversationidEvaluationsEvaluationidPutAsyncWithHttpInfo(conversationId, evaluationId, body, expand);
=======
        /// <param name="body">query (optional)</param>
        /// <returns>Task of AggregateQueryResponse</returns>
        public async System.Threading.Tasks.Task<AggregateQueryResponse> PostEvaluationsAggregatesQueryAsync (AggregationQuery body = null)
        {
             ApiResponse<AggregateQueryResponse> localVarResponse = await PostEvaluationsAggregatesQueryAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query for evaluation aggregates 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> QualityConversationsConversationidEvaluationsEvaluationidPutAsyncWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidPut");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidPut");

            var localVarPath = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
=======
        /// <param name="body">query (optional)</param>
        /// <returns>Task of ApiResponse (AggregateQueryResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AggregateQueryResponse>> PostEvaluationsAggregatesQueryAsyncWithHttpInfo (AggregationQuery body = null)
        {

            var localVarPath = "/api/v2/analytics/evaluations/aggregates/query";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostEvaluationsAggregatesQuery: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEvaluationsAggregatesQuery: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AggregateQueryResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AggregateQueryResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AggregateQueryResponse)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Create an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        public Evaluation QualityConversationsConversationidEvaluationsPost (string conversationId, Evaluation body = null, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = QualityConversationsConversationidEvaluationsPostWithHttpInfo(conversationId, body, expand);
=======
        /// Score evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>EvaluationScoringSet</returns>
        public EvaluationScoringSet PostEvaluationsScoring (EvaluationFormAndScoringSet body = null)
        {
             ApiResponse<EvaluationScoringSet> localVarResponse = PostEvaluationsScoringWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
<<<<<<< HEAD
        /// Create an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > QualityConversationsConversationidEvaluationsPostWithHttpInfo (string conversationId, Evaluation body = null, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->QualityConversationsConversationidEvaluationsPost");

            var localVarPath = "/api/v1/quality/conversations/{conversationId}/evaluations";
=======
        /// Score evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>ApiResponse of EvaluationScoringSet</returns>
        public ApiResponse< EvaluationScoringSet > PostEvaluationsScoringWithHttpInfo (EvaluationFormAndScoringSet body = null)
        {

            var localVarPath = "/api/v2/quality/evaluations/scoring";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostEvaluationsScoring: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEvaluationsScoring: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationScoringSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationScoringSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationScoringSet)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
<<<<<<< HEAD
        /// Create an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        public async System.Threading.Tasks.Task<Evaluation> QualityConversationsConversationidEvaluationsPostAsync (string conversationId, Evaluation body = null, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = await QualityConversationsConversationidEvaluationsPostAsyncWithHttpInfo(conversationId, body, expand);
=======
        /// Score evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>Task of EvaluationScoringSet</returns>
        public async System.Threading.Tasks.Task<EvaluationScoringSet> PostEvaluationsScoringAsync (EvaluationFormAndScoringSet body = null)
        {
             ApiResponse<EvaluationScoringSet> localVarResponse = await PostEvaluationsScoringAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
<<<<<<< HEAD
        /// Create an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> QualityConversationsConversationidEvaluationsPostAsyncWithHttpInfo (string conversationId, Evaluation body = null, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->QualityConversationsConversationidEvaluationsPost");

            var localVarPath = "/api/v1/quality/conversations/{conversationId}/evaluations";
=======
        /// Score evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationScoringSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationScoringSet>> PostEvaluationsScoringAsyncWithHttpInfo (EvaluationFormAndScoringSet body = null)
        {

            var localVarPath = "/api/v2/quality/evaluations/scoring";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostEvaluationsScoring: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostEvaluationsScoring: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationScoringSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationScoringSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationScoringSet)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>EvaluationEntityListing</returns>
        public EvaluationEntityListing QualityEvaluationsQueryGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
        {
             ApiResponse<EvaluationEntityListing> localVarResponse = QualityEvaluationsQueryGetWithHttpInfo(pageSize, pageNumber, sortBy, expand, conversationId, agentUserId, evaluatorUserId, queueId, startTime, endTime, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum);
=======
        /// <param name="body"> (optional)</param>
        /// <returns>EvaluationForm</returns>
        public EvaluationForm PostForms (EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> localVarResponse = PostFormsWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        public ApiResponse< EvaluationEntityListing > QualityEvaluationsQueryGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
        {

            var localVarPath = "/api/v1/quality/evaluations/query";
=======
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > PostFormsWithHttpInfo (EvaluationForm body = null)
        {

            var localVarPath = "/api/v2/quality/forms";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            if (agentUserId != null) localVarQueryParams.Add("agentUserId", Configuration.ApiClient.ParameterToString(agentUserId)); // query parameter
            if (evaluatorUserId != null) localVarQueryParams.Add("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)); // query parameter
            if (queueId != null) localVarQueryParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (evaluationState != null) localVarQueryParams.Add("evaluationState", Configuration.ApiClient.ParameterToString(evaluationState)); // query parameter
            if (isReleased != null) localVarQueryParams.Add("isReleased", Configuration.ApiClient.ParameterToString(isReleased)); // query parameter
            if (agentHasRead != null) localVarQueryParams.Add("agentHasRead", Configuration.ApiClient.ParameterToString(agentHasRead)); // query parameter
            if (expandAnswerTotalScores != null) localVarQueryParams.Add("expandAnswerTotalScores", Configuration.ApiClient.ParameterToString(expandAnswerTotalScores)); // query parameter
            if (maximum != null) localVarQueryParams.Add("maximum", Configuration.ApiClient.ParameterToString(maximum)); // query parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsQueryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsQueryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostForms: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostForms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationEntityListing> QualityEvaluationsQueryGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
        {
             ApiResponse<EvaluationEntityListing> localVarResponse = await QualityEvaluationsQueryGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, conversationId, agentUserId, evaluatorUserId, queueId, startTime, endTime, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum);
=======
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> PostFormsAsync (EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> localVarResponse = await PostFormsAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="conversationId">conversationId specified (optional)</param>
        /// <param name="agentUserId">user id of the agent (optional)</param>
        /// <param name="evaluatorUserId">evaluator user id (optional)</param>
        /// <param name="queueId">queue id (optional)</param>
        /// <param name="startTime">start time of the evaluation query (optional)</param>
        /// <param name="endTime">end time of the evaluation query (optional)</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished (optional)</param>
        /// <param name="isReleased">the evaluation has been released (optional)</param>
        /// <param name="agentHasRead">agent has the evaluation (optional)</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations (optional)</param>
        /// <param name="maximum">maximum (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> QualityEvaluationsQueryGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
        {

            var localVarPath = "/api/v1/quality/evaluations/query";
=======
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> PostFormsAsyncWithHttpInfo (EvaluationForm body = null)
        {

            var localVarPath = "/api/v2/quality/forms";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            if (agentUserId != null) localVarQueryParams.Add("agentUserId", Configuration.ApiClient.ParameterToString(agentUserId)); // query parameter
            if (evaluatorUserId != null) localVarQueryParams.Add("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)); // query parameter
            if (queueId != null) localVarQueryParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (evaluationState != null) localVarQueryParams.Add("evaluationState", Configuration.ApiClient.ParameterToString(evaluationState)); // query parameter
            if (isReleased != null) localVarQueryParams.Add("isReleased", Configuration.ApiClient.ParameterToString(isReleased)); // query parameter
            if (agentHasRead != null) localVarQueryParams.Add("agentHasRead", Configuration.ApiClient.ParameterToString(agentHasRead)); // query parameter
            if (expandAnswerTotalScores != null) localVarQueryParams.Add("expandAnswerTotalScores", Configuration.ApiClient.ParameterToString(expandAnswerTotalScores)); // query parameter
            if (maximum != null) localVarQueryParams.Add("maximum", Configuration.ApiClient.ParameterToString(maximum)); // query parameter
=======
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsQueryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsQueryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostForms: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostForms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">query (optional)</param>
        /// <param name="expand">evaluator,agent (optional)</param>
        /// <returns>EvaluationEntityListing</returns>
        public EvaluationEntityListing QualityEvaluationsQueryPost (EvaluationQueryRequest body = null, string expand = null)
        {
             ApiResponse<EvaluationEntityListing> localVarResponse = QualityEvaluationsQueryPostWithHttpInfo(body, expand);
=======
        /// <param name="body"> (optional)</param>
        /// <returns>EvaluationForm</returns>
        public EvaluationForm PostPublishedforms (EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> localVarResponse = PostPublishedformsWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">query (optional)</param>
        /// <param name="expand">evaluator,agent (optional)</param>
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        public ApiResponse< EvaluationEntityListing > QualityEvaluationsQueryPostWithHttpInfo (EvaluationQueryRequest body = null, string expand = null)
        {

            var localVarPath = "/api/v1/quality/evaluations/query";
=======
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > PostPublishedformsWithHttpInfo (EvaluationForm body = null)
        {

            var localVarPath = "/api/v2/quality/publishedforms";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostPublishedforms: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostPublishedforms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">query (optional)</param>
        /// <param name="expand">evaluator,agent (optional)</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationEntityListing> QualityEvaluationsQueryPostAsync (EvaluationQueryRequest body = null, string expand = null)
        {
             ApiResponse<EvaluationEntityListing> localVarResponse = await QualityEvaluationsQueryPostAsyncWithHttpInfo(body, expand);
=======
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> PostPublishedformsAsync (EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> localVarResponse = await PostPublishedformsAsyncWithHttpInfo(body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Publish an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">query (optional)</param>
        /// <param name="expand">evaluator,agent (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> QualityEvaluationsQueryPostAsyncWithHttpInfo (EvaluationQueryRequest body = null, string expand = null)
        {

            var localVarPath = "/api/v1/quality/evaluations/query";
=======
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> PostPublishedformsAsyncWithHttpInfo (EvaluationForm body = null)
        {

            var localVarPath = "/api/v2/quality/publishedforms";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PostPublishedforms: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostPublishedforms: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>EvaluationScoringSet</returns>
        public EvaluationScoringSet QualityEvaluationsScoringPost (EvaluationFormAndScoringSet body = null)
        {
             ApiResponse<EvaluationScoringSet> localVarResponse = QualityEvaluationsScoringPostWithHttpInfo(body);
=======
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Calibration</returns>
        public Calibration PutCalibrationsCalibrationId (string calibrationId, Calibration body = null)
        {
             ApiResponse<Calibration> localVarResponse = PutCalibrationsCalibrationIdWithHttpInfo(calibrationId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>ApiResponse of EvaluationScoringSet</returns>
        public ApiResponse< EvaluationScoringSet > QualityEvaluationsScoringPostWithHttpInfo (EvaluationFormAndScoringSet body = null)
        {

            var localVarPath = "/api/v1/quality/evaluations/scoring";
=======
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > PutCalibrationsCalibrationIdWithHttpInfo (string calibrationId, Calibration body = null)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->PutCalibrationsCalibrationId");

            var localVarPath = "/api/v2/quality/calibrations/{calibrationId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsScoringPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsScoringPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationScoringSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationScoringSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationScoringSet)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutCalibrationsCalibrationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCalibrationsCalibrationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>Task of EvaluationScoringSet</returns>
        public async System.Threading.Tasks.Task<EvaluationScoringSet> QualityEvaluationsScoringPostAsync (EvaluationFormAndScoringSet body = null)
        {
             ApiResponse<EvaluationScoringSet> localVarResponse = await QualityEvaluationsScoringPostAsyncWithHttpInfo(body);
=======
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> PutCalibrationsCalibrationIdAsync (string calibrationId, Calibration body = null)
        {
             ApiResponse<Calibration> localVarResponse = await PutCalibrationsCalibrationIdAsyncWithHttpInfo(calibrationId, body);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationScoringSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationScoringSet>> QualityEvaluationsScoringPostAsyncWithHttpInfo (EvaluationFormAndScoringSet body = null)
        {

            var localVarPath = "/api/v1/quality/evaluations/scoring";
=======
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> PutCalibrationsCalibrationIdAsyncWithHttpInfo (string calibrationId, Calibration body = null)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->PutCalibrationsCalibrationId");

            var localVarPath = "/api/v2/quality/calibrations/{calibrationId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
=======
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
<<<<<<< HEAD
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsScoringPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsScoringPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationScoringSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationScoringSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationScoringSet)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutCalibrationsCalibrationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutCalibrationsCalibrationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Update an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>EvaluatorActivityEntityListing</returns>
        public EvaluatorActivityEntityListing QualityEvaluatorsActivityGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)
        {
             ApiResponse<EvaluatorActivityEntityListing> localVarResponse = QualityEvaluatorsActivityGetWithHttpInfo(pageSize, pageNumber, sortBy, expand, startTime, endTime, name, permission, group);
=======
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        public Evaluation PutConversationsConversationIdEvaluationsEvaluationId (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = PutConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo(conversationId, evaluationId, body, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>ApiResponse of EvaluatorActivityEntityListing</returns>
        public ApiResponse< EvaluatorActivityEntityListing > QualityEvaluatorsActivityGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)
        {

            var localVarPath = "/api/v1/quality/evaluators/activity";
=======
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > PutConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->PutConversationsConversationIdEvaluationsEvaluationId");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->PutConversationsConversationIdEvaluationsEvaluationId");

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (permission != null) localVarQueryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            if (group != null) localVarQueryParams.Add("group", Configuration.ApiClient.ParameterToString(group)); // query parameter
=======
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
<<<<<<< HEAD
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluatorsActivityGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluatorsActivityGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluatorActivityEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluatorActivityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluatorActivityEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutConversationsConversationIdEvaluationsEvaluationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutConversationsConversationIdEvaluationsEvaluationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

        /// <summary>
        /// Update an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of EvaluatorActivityEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluatorActivityEntityListing> QualityEvaluatorsActivityGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)
        {
             ApiResponse<EvaluatorActivityEntityListing> localVarResponse = await QualityEvaluatorsActivityGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, startTime, endTime, name, permission, group);
=======
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        public async System.Threading.Tasks.Task<Evaluation> PutConversationsConversationIdEvaluationsEvaluationIdAsync (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = await PutConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo(conversationId, evaluationId, body, expand);
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
<<<<<<< HEAD
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (optional)</param>
        /// <param name="name">Evaluator name (optional)</param>
        /// <param name="permission">permission strings (optional)</param>
        /// <param name="group">group id (optional)</param>
        /// <returns>Task of ApiResponse (EvaluatorActivityEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluatorActivityEntityListing>> QualityEvaluatorsActivityGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)
        {

            var localVarPath = "/api/v1/quality/evaluators/activity";
=======
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> PutConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->PutConversationsConversationIdEvaluationsEvaluationId");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->PutConversationsConversationIdEvaluationsEvaluationId");

            var localVarPath = "/api/v2/quality/conversations/{conversationId}/evaluations/{evaluationId}";
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
<<<<<<< HEAD
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (permission != null) localVarQueryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            if (group != null) localVarQueryParams.Add("group", Configuration.ApiClient.ParameterToString(group)); // query parameter

            // authentication (PureCloud Auth) required
=======
            if (conversationId != null) localVarPathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutConversationsConversationIdEvaluationsEvaluationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutConversationsConversationIdEvaluationsEvaluationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>EvaluationForm</returns>
        public EvaluationForm PutFormsFormId (string formId, EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> localVarResponse = PutFormsFormIdWithHttpInfo(formId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of EvaluationForm</returns>
        public ApiResponse< EvaluationForm > PutFormsFormIdWithHttpInfo (string formId, EvaluationForm body = null)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->PutFormsFormId");

            var localVarPath = "/api/v2/quality/forms/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
<<<<<<< HEAD

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
=======

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PutFormsFormId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutFormsFormId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
            
        }

        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of EvaluationForm</returns>
        public async System.Threading.Tasks.Task<EvaluationForm> PutFormsFormIdAsync (string formId, EvaluationForm body = null)
        {
             ApiResponse<EvaluationForm> localVarResponse = await PutFormsFormIdAsyncWithHttpInfo(formId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an evaluation form. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="formId">Form ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationForm)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationForm>> PutFormsFormIdAsyncWithHttpInfo (string formId, EvaluationForm body = null)
        {
            // verify the required parameter 'formId' is set
            if (formId == null)
                throw new ApiException(400, "Missing required parameter 'formId' when calling QualityApi->PutFormsFormId");

            var localVarPath = "/api/v2/quality/forms/{formId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (formId != null) localVarPathParams.Add("formId", Configuration.ApiClient.ParameterToString(formId)); // path parameter
            if (body.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
<<<<<<< HEAD
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluatorsActivityGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluatorsActivityGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluatorActivityEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluatorActivityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluatorActivityEntityListing)));
=======
                throw new ApiException (localVarStatusCode, "Error calling PutFormsFormId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutFormsFormId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationForm>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationForm) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationForm)));
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

    }
}
