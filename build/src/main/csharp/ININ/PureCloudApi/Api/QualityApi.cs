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
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns></returns>
        void ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete (string conversationId, string recordingId, string annotationId);

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
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDeleteWithHttpInfo (string conversationId, string recordingId, string annotationId);
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
        /// <returns>Annotation</returns>
        Annotation ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet (string conversationId, string recordingId, string annotationId);

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
        /// <returns>ApiResponse of Annotation</returns>
        ApiResponse<Annotation> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGetWithHttpInfo (string conversationId, string recordingId, string annotationId);
        /// <summary>
        /// Update annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>Annotation</returns>
        Annotation ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut (string conversationId, string recordingId, string annotationId, Annotation body = null);

        /// <summary>
        /// Update annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays&#x3D;10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated. (optional)</param>
        /// <returns></returns>
        void ConversationsConversationidRecordingsRecordingidPut (string conversationId, string recordingId, Recording body, int? restoreDays = null);

        /// <summary>
        /// Updates the retention records on a recording.
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays&#x3D;10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated. (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> ConversationsConversationidRecordingsRecordingidPutWithHttpInfo (string conversationId, string recordingId, Recording body, int? restoreDays = null);
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
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <returns>ApiResponse of AgentActivityEntityListing</returns>
        ApiResponse<AgentActivityEntityListing> QualityAgentsActivityGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);
        /// <summary>
        /// Delete a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Calibration</returns>
        Calibration QualityCalibrationsCalibrationidDelete (string calibrationId, string calibratorId = null);

        /// <summary>
        /// Delete a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> QualityCalibrationsCalibrationidDeleteWithHttpInfo (string calibrationId, string calibratorId = null);
        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Calibration</returns>
        Calibration QualityCalibrationsCalibrationidGet (string calibrationId, string calibratorId = null);

        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> QualityCalibrationsCalibrationidGetWithHttpInfo (string calibrationId, string calibratorId = null);
        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Calibration</returns>
        Calibration QualityCalibrationsCalibrationidPut (string calibrationId, Calibration body = null);

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> QualityCalibrationsCalibrationidPutWithHttpInfo (string calibrationId, Calibration body = null);
        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        CalibrationEntityListing QualityCalibrationsGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null);

        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        ApiResponse<CalibrationEntityListing> QualityCalibrationsGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null);
        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Calibration</returns>
        Calibration QualityCalibrationsPost (Calibration body = null, string expand = null);

        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> QualityCalibrationsPostWithHttpInfo (Calibration body = null, string expand = null);
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
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>QualityAuditPage</returns>
        QualityAuditPage QualityConversationsConversationidAuditsGet (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null);

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
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>ApiResponse of QualityAuditPage</returns>
        ApiResponse<QualityAuditPage> QualityConversationsConversationidAuditsGetWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null);
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
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>Task of Annotation</returns>
        System.Threading.Tasks.Task<Annotation> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPutAsync (string conversationId, string recordingId, string annotationId, Annotation body = null);

        /// <summary>
        /// Update annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation (optional)</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Annotation>> ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPutAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body = null);
        /// <summary>
        /// Get annotations for recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of List&lt;Annotation&gt;</returns>
        System.Threading.Tasks.Task<List<Annotation>> ConversationsConversationidRecordingsRecordingidAnnotationsGetAsync (string conversationId, string recordingId);

        /// <summary>
        /// Get annotations for recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of ApiResponse (List&lt;Annotation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Annotation>>> ConversationsConversationidRecordingsRecordingidAnnotationsGetAsyncWithHttpInfo (string conversationId, string recordingId);
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
        /// <returns>Task of Annotation</returns>
        System.Threading.Tasks.Task<Annotation> ConversationsConversationidRecordingsRecordingidAnnotationsPostAsync (string conversationId, string recordingId, Annotation body = null);

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
        /// <returns>Task of ApiResponse (Annotation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Annotation>> ConversationsConversationidRecordingsRecordingidAnnotationsPostAsyncWithHttpInfo (string conversationId, string recordingId, Annotation body = null);
        /// <summary>
        /// Gets a specific recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays&#x3D;10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated. (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task ConversationsConversationidRecordingsRecordingidPutAsync (string conversationId, string recordingId, Recording body, int? restoreDays = null);

        /// <summary>
        /// Updates the retention records on a recording.
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays&#x3D;10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated. (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> ConversationsConversationidRecordingsRecordingidPutAsyncWithHttpInfo (string conversationId, string recordingId, Recording body, int? restoreDays = null);
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
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> QualityCalibrationsCalibrationidDeleteAsync (string calibrationId, string calibratorId = null);

        /// <summary>
        /// Delete a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> QualityCalibrationsCalibrationidDeleteAsyncWithHttpInfo (string calibrationId, string calibratorId = null);
        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> QualityCalibrationsCalibrationidGetAsync (string calibrationId, string calibratorId = null);

        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> QualityCalibrationsCalibrationidGetAsyncWithHttpInfo (string calibrationId, string calibratorId = null);
        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> QualityCalibrationsCalibrationidPutAsync (string calibrationId, Calibration body = null);

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> QualityCalibrationsCalibrationidPutAsyncWithHttpInfo (string calibrationId, Calibration body = null);
        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        System.Threading.Tasks.Task<CalibrationEntityListing> QualityCalibrationsGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null);

        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
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
        System.Threading.Tasks.Task<ApiResponse<CalibrationEntityListing>> QualityCalibrationsGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null);
        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> QualityCalibrationsPostAsync (Calibration body = null, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<Calibration>> QualityCalibrationsPostAsyncWithHttpInfo (Calibration body = null, string expand = null);
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
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>Task of QualityAuditPage</returns>
        System.Threading.Tasks.Task<QualityAuditPage> QualityConversationsConversationidAuditsGetAsync (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null);

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
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>Task of ApiResponse (QualityAuditPage)</returns>
        System.Threading.Tasks.Task<ApiResponse<QualityAuditPage>> QualityConversationsConversationidAuditsGetAsyncWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null);
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
        System.Threading.Tasks.Task<Evaluation> QualityConversationsConversationidEvaluationsEvaluationidDeleteAsync (string conversationId, string evaluationId, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> QualityConversationsConversationidEvaluationsEvaluationidDeleteAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null);
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
        System.Threading.Tasks.Task<Evaluation> QualityConversationsConversationidEvaluationsEvaluationidGetAsync (string conversationId, string evaluationId, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> QualityConversationsConversationidEvaluationsEvaluationidGetAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null);
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
        System.Threading.Tasks.Task<Evaluation> QualityConversationsConversationidEvaluationsEvaluationidPutAsync (string conversationId, string evaluationId, Evaluation body = null, string expand = null);

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
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> QualityConversationsConversationidEvaluationsEvaluationidPutAsyncWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null);
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
        System.Threading.Tasks.Task<Evaluation> QualityConversationsConversationidEvaluationsPostAsync (string conversationId, Evaluation body = null, string expand = null);

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
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> QualityConversationsConversationidEvaluationsPostAsyncWithHttpInfo (string conversationId, Evaluation body = null, string expand = null);
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
        /// <returns>Task of EvaluationEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationEntityListing> QualityEvaluationsQueryGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);

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
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> QualityEvaluationsQueryGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);
        /// <summary>
        /// Query evaluations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">evaluator,agent (optional)</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationEntityListing> QualityEvaluationsQueryPostAsync (EvaluationQueryRequest body = null, string expand = null);

        /// <summary>
        /// Query evaluations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">evaluator,agent (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> QualityEvaluationsQueryPostAsyncWithHttpInfo (EvaluationQueryRequest body = null, string expand = null);
        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>Task of EvaluationScoringSet</returns>
        System.Threading.Tasks.Task<EvaluationScoringSet> QualityEvaluationsScoringPostAsync (EvaluationFormAndScoringSet body = null);

        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationScoringSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationScoringSet>> QualityEvaluationsScoringPostAsyncWithHttpInfo (EvaluationFormAndScoringSet body = null);
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
        /// <returns>Task of EvaluatorActivityEntityListing</returns>
        System.Threading.Tasks.Task<EvaluatorActivityEntityListing> QualityEvaluatorsActivityGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null);

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
        /// <returns>Task of ApiResponse (EvaluatorActivityEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluatorActivityEntityListing>> QualityEvaluatorsActivityGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null);
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
        /// Get all of a Conversation&#39;s Recordings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. (optional, default to 5000)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>List&lt;Recording&gt;</returns>
        public List<Recording> ConversationsConversationidRecordingsGet (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
             ApiResponse<List<Recording>> localVarResponse = ConversationsConversationidRecordingsGetWithHttpInfo(conversationId, maxWaitMs, formatId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (maxWaitMs != null) localVarQueryParams.Add("maxWaitMs", Configuration.ApiClient.ParameterToString(maxWaitMs)); // query parameter
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Recording>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Recording>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Recording>)));
            
        }

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. (optional, default to 5000)</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.) (optional, default to WEBM)</param>
        /// <returns>Task of List&lt;Recording&gt;</returns>
        public async System.Threading.Tasks.Task<List<Recording>> ConversationsConversationidRecordingsGetAsync (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
             ApiResponse<List<Recording>> localVarResponse = await ConversationsConversationidRecordingsGetAsyncWithHttpInfo(conversationId, maxWaitMs, formatId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            if (maxWaitMs != null) localVarQueryParams.Add("maxWaitMs", Configuration.ApiClient.ParameterToString(maxWaitMs)); // query parameter
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Recording>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Recording>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Recording>)));
            
        }

        /// <summary>
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) localVarPathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter

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

        }

        /// <summary>
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) localVarPathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
             return localVarResponse.Data;
        }

        /// <summary>
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) localVarPathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)));
            
        }

        /// <summary>
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
             return localVarResponse.Data;

        }

        /// <summary>
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) localVarPathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)));
            
        }

        /// <summary>
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
             return localVarResponse.Data;
        }

        /// <summary>
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

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)));
            
        }

        /// <summary>
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
             return localVarResponse.Data;

        }

        /// <summary>
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsAnnotationidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)));
            
        }

        /// <summary>
        /// Get annotations for recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>List&lt;Annotation&gt;</returns>
        public List<Annotation> ConversationsConversationidRecordingsRecordingidAnnotationsGet (string conversationId, string recordingId)
        {
             ApiResponse<List<Annotation>> localVarResponse = ConversationsConversationidRecordingsRecordingidAnnotationsGetWithHttpInfo(conversationId, recordingId);
             return localVarResponse.Data;
        }

        /// <summary>
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Annotation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Annotation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Annotation>)));
            
        }

        /// <summary>
        /// Get annotations for recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of List&lt;Annotation&gt;</returns>
        public async System.Threading.Tasks.Task<List<Annotation>> ConversationsConversationidRecordingsRecordingidAnnotationsGetAsync (string conversationId, string recordingId)
        {
             ApiResponse<List<Annotation>> localVarResponse = await ConversationsConversationidRecordingsRecordingidAnnotationsGetAsyncWithHttpInfo(conversationId, recordingId);
             return localVarResponse.Data;

        }

        /// <summary>
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Annotation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Annotation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Annotation>)));
            
        }

        /// <summary>
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
             return localVarResponse.Data;
        }

        /// <summary>
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)));
            
        }

        /// <summary>
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
             return localVarResponse.Data;

        }

        /// <summary>
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidAnnotationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)));
            
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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (maxWaitMs != null) localVarQueryParams.Add("maxWaitMs", Configuration.ApiClient.ParameterToString(maxWaitMs)); // query parameter
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
            if (download != null) localVarQueryParams.Add("download", Configuration.ApiClient.ParameterToString(download)); // query parameter
            if (fileName != null) localVarQueryParams.Add("fileName", Configuration.ApiClient.ParameterToString(fileName)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
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
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task ConversationsConversationidRecordingsRecordingidGetAsync (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null)
        {
             await ConversationsConversationidRecordingsRecordingidGetAsyncWithHttpInfo(conversationId, recordingId, maxWaitMs, formatId, download, fileName);

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
            if (recordingId != null) localVarPathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (maxWaitMs != null) localVarQueryParams.Add("maxWaitMs", Configuration.ApiClient.ParameterToString(maxWaitMs)); // query parameter
            if (formatId != null) localVarQueryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
            if (download != null) localVarQueryParams.Add("download", Configuration.ApiClient.ParameterToString(download)); // query parameter
            if (fileName != null) localVarQueryParams.Add("fileName", Configuration.ApiClient.ParameterToString(fileName)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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

            // authentication (PureCloud Auth) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
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

        }

        /// <summary>
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
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling ConversationsConversationidRecordingsRecordingidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Gets a list of Agent Activities Including the number of evaluations and average evaluation score
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <returns>AgentActivityEntityListing</returns>
        public AgentActivityEntityListing QualityAgentsActivityGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {
             ApiResponse<AgentActivityEntityListing> localVarResponse = QualityAgentsActivityGetWithHttpInfo(pageSize, pageNumber, sortBy, expand, startTime, endTime, agentUserId, evaluatorUserId, name, group);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a list of Agent Activities Including the number of evaluations and average evaluation score
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <returns>ApiResponse of AgentActivityEntityListing</returns>
        public ApiResponse< AgentActivityEntityListing > QualityAgentsActivityGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {

            var localVarPath = "/api/v1/quality/agents/activity";
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
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (agentUserId != null) localVarQueryParams.Add("agentUserId", Configuration.ApiClient.ParameterToString(agentUserId)); // query parameter
            if (evaluatorUserId != null) localVarQueryParams.Add("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (group != null) localVarQueryParams.Add("group", Configuration.ApiClient.ParameterToString(group)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityAgentsActivityGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityAgentsActivityGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentActivityEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AgentActivityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentActivityEntityListing)));
            
        }

        /// <summary>
        /// Gets a list of Agent Activities Including the number of evaluations and average evaluation score
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        public async System.Threading.Tasks.Task<AgentActivityEntityListing> QualityAgentsActivityGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {
             ApiResponse<AgentActivityEntityListing> localVarResponse = await QualityAgentsActivityGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, startTime, endTime, agentUserId, evaluatorUserId, name, group);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a list of Agent Activities Including the number of evaluations and average evaluation score
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        public async System.Threading.Tasks.Task<ApiResponse<AgentActivityEntityListing>> QualityAgentsActivityGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {

            var localVarPath = "/api/v1/quality/agents/activity";
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
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (agentUserId != null) localVarQueryParams.Add("agentUserId", Configuration.ApiClient.ParameterToString(agentUserId)); // query parameter
            if (evaluatorUserId != null) localVarQueryParams.Add("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (group != null) localVarQueryParams.Add("group", Configuration.ApiClient.ParameterToString(group)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityAgentsActivityGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityAgentsActivityGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<AgentActivityEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AgentActivityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(AgentActivityEntityListing)));
            
        }

        /// <summary>
        /// Delete a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Calibration</returns>
        public Calibration QualityCalibrationsCalibrationidDelete (string calibrationId, string calibratorId = null)
        {
             ApiResponse<Calibration> localVarResponse = QualityCalibrationsCalibrationidDeleteWithHttpInfo(calibrationId, calibratorId);
             return localVarResponse.Data;
        }

        /// <summary>
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
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
            
        }

        /// <summary>
        /// Delete a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> QualityCalibrationsCalibrationidDeleteAsync (string calibrationId, string calibratorId = null)
        {
             ApiResponse<Calibration> localVarResponse = await QualityCalibrationsCalibrationidDeleteAsyncWithHttpInfo(calibrationId, calibratorId);
             return localVarResponse.Data;

        }

        /// <summary>
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
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
            
        }

        /// <summary>
        /// Get a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Calibration</returns>
        public Calibration QualityCalibrationsCalibrationidGet (string calibrationId, string calibratorId = null)
        {
             ApiResponse<Calibration> localVarResponse = QualityCalibrationsCalibrationidGetWithHttpInfo(calibrationId, calibratorId);
             return localVarResponse.Data;
        }

        /// <summary>
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
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
            
        }

        /// <summary>
        /// Get a calibration by id. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId (optional)</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> QualityCalibrationsCalibrationidGetAsync (string calibrationId, string calibratorId = null)
        {
             ApiResponse<Calibration> localVarResponse = await QualityCalibrationsCalibrationidGetAsyncWithHttpInfo(calibrationId, calibratorId);
             return localVarResponse.Data;

        }

        /// <summary>
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
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
            
        }

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Calibration</returns>
        public Calibration QualityCalibrationsCalibrationidPut (string calibrationId, Calibration body = null)
        {
             ApiResponse<Calibration> localVarResponse = QualityCalibrationsCalibrationidPutWithHttpInfo(calibrationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
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
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
            
        }

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration (optional)</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> QualityCalibrationsCalibrationidPutAsync (string calibrationId, Calibration body = null)
        {
             ApiResponse<Calibration> localVarResponse = await QualityCalibrationsCalibrationidPutAsyncWithHttpInfo(calibrationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
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
            if (calibrationId != null) localVarPathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsCalibrationidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
            
        }

        /// <summary>
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
             return localVarResponse.Data;
        }

        /// <summary>
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
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CalibrationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CalibrationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CalibrationEntityListing)));
            
        }

        /// <summary>
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
             return localVarResponse.Data;

        }

        /// <summary>
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
            if (conversationId != null) localVarQueryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (calibratorId != null) localVarQueryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<CalibrationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CalibrationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CalibrationEntityListing)));
            
        }

        /// <summary>
        /// Create a calibration 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Calibration</returns>
        public Calibration QualityCalibrationsPost (Calibration body = null, string expand = null)
        {
             ApiResponse<Calibration> localVarResponse = QualityCalibrationsPostWithHttpInfo(body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a calibration 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > QualityCalibrationsPostWithHttpInfo (Calibration body = null, string expand = null)
        {

            var localVarPath = "/api/v1/quality/calibrations";
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
            
        }

        /// <summary>
        /// Create a calibration 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> QualityCalibrationsPostAsync (Calibration body = null, string expand = null)
        {
             ApiResponse<Calibration> localVarResponse = await QualityCalibrationsPostAsyncWithHttpInfo(body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a calibration 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">calibration (optional)</param>
        /// <param name="expand">calibratorId (optional)</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> QualityCalibrationsPostAsyncWithHttpInfo (Calibration body = null, string expand = null)
        {

            var localVarPath = "/api/v1/quality/calibrations";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityCalibrationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Calibration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Calibration)));
            
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
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>QualityAuditPage</returns>
        public QualityAuditPage QualityConversationsConversationidAuditsGet (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)
        {
             ApiResponse<QualityAuditPage> localVarResponse = QualityConversationsConversationidAuditsGetWithHttpInfo(conversationId, pageSize, pageNumber, sortBy, expand, recordingId, entityType);
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
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>ApiResponse of QualityAuditPage</returns>
        public ApiResponse< QualityAuditPage > QualityConversationsConversationidAuditsGetWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->QualityConversationsConversationidAuditsGet");

            var localVarPath = "/api/v1/quality/conversations/{conversationId}/audits";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (recordingId != null) localVarQueryParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // query parameter
            if (entityType != null) localVarQueryParams.Add("entityType", Configuration.ApiClient.ParameterToString(entityType)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidAuditsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidAuditsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QualityAuditPage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QualityAuditPage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QualityAuditPage)));
            
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
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>Task of QualityAuditPage</returns>
        public async System.Threading.Tasks.Task<QualityAuditPage> QualityConversationsConversationidAuditsGetAsync (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)
        {
             ApiResponse<QualityAuditPage> localVarResponse = await QualityConversationsConversationidAuditsGetAsyncWithHttpInfo(conversationId, pageSize, pageNumber, sortBy, expand, recordingId, entityType);
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
        /// <param name="recordingId">id of the recording (optional)</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation (optional, default to RECORDING)</param>
        /// <returns>Task of ApiResponse (QualityAuditPage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QualityAuditPage>> QualityConversationsConversationidAuditsGetAsyncWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->QualityConversationsConversationidAuditsGet");

            var localVarPath = "/api/v1/quality/conversations/{conversationId}/audits";
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
            if (pageSize != null) localVarQueryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) localVarQueryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) localVarQueryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (recordingId != null) localVarQueryParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // query parameter
            if (entityType != null) localVarQueryParams.Add("entityType", Configuration.ApiClient.ParameterToString(entityType)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidAuditsGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidAuditsGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<QualityAuditPage>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QualityAuditPage) Configuration.ApiClient.Deserialize(localVarResponse, typeof(QualityAuditPage)));
            
        }

        /// <summary>
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
        public ApiResponse< Evaluation > QualityConversationsConversationidEvaluationsEvaluationidDeleteWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidDelete");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidDelete");

            var localVarPath = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
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
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<Evaluation> QualityConversationsConversationidEvaluationsEvaluationidDeleteAsync (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = await QualityConversationsConversationidEvaluationsEvaluationidDeleteAsyncWithHttpInfo(conversationId, evaluationId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
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
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidDelete: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidDelete: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <returns>Evaluation</returns>
        public Evaluation QualityConversationsConversationidEvaluationsEvaluationidGet (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = QualityConversationsConversationidEvaluationsEvaluationidGetWithHttpInfo(conversationId, evaluationId, expand);
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
        public ApiResponse< Evaluation > QualityConversationsConversationidEvaluationsEvaluationidGetWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidGet");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidGet");

            var localVarPath = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
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
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<Evaluation> QualityConversationsConversationidEvaluationsEvaluationidGetAsync (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = await QualityConversationsConversationidEvaluationsEvaluationidGetAsyncWithHttpInfo(conversationId, evaluationId, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm (optional)</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> QualityConversationsConversationidEvaluationsEvaluationidGetAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidGet");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->QualityConversationsConversationidEvaluationsEvaluationidGet");

            var localVarPath = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
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
            if (evaluationId != null) localVarPathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            if (expand != null) localVarQueryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        /// <summary>
        /// Update an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Evaluation</returns>
        public Evaluation QualityConversationsConversationidEvaluationsEvaluationidPut (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = QualityConversationsConversationidEvaluationsEvaluationidPutWithHttpInfo(conversationId, evaluationId, body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        /// <summary>
        /// Update an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation (optional)</param>
        /// <param name="expand">evaluatorId (optional)</param>
        /// <returns>Task of Evaluation</returns>
        public async System.Threading.Tasks.Task<Evaluation> QualityConversationsConversationidEvaluationsEvaluationidPutAsync (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
             ApiResponse<Evaluation> localVarResponse = await QualityConversationsConversationidEvaluationsEvaluationidPutAsyncWithHttpInfo(conversationId, evaluationId, body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update an evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidPut: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsEvaluationidPut: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        /// <summary>
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
             return localVarResponse.Data;
        }

        /// <summary>
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        /// <summary>
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
             return localVarResponse.Data;

        }

        /// <summary>
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityConversationsConversationidEvaluationsPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Evaluation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Evaluation)));
            
        }

        /// <summary>
        /// Queries Evaluations and returns a paged list Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </summary>
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
        public EvaluationEntityListing QualityEvaluationsQueryGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
        {
             ApiResponse<EvaluationEntityListing> localVarResponse = QualityEvaluationsQueryGetWithHttpInfo(pageSize, pageNumber, sortBy, expand, conversationId, agentUserId, evaluatorUserId, queueId, startTime, endTime, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum);
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
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsQueryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsQueryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationEntityListing)));
            
        }

        /// <summary>
        /// Queries Evaluations and returns a paged list Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </summary>
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
        /// <returns>Task of EvaluationEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationEntityListing> QualityEvaluationsQueryGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
        {
             ApiResponse<EvaluationEntityListing> localVarResponse = await QualityEvaluationsQueryGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, conversationId, agentUserId, evaluatorUserId, queueId, startTime, endTime, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum);
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
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsQueryGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsQueryGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationEntityListing)));
            
        }

        /// <summary>
        /// Query evaluations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">evaluator,agent (optional)</param>
        /// <returns>EvaluationEntityListing</returns>
        public EvaluationEntityListing QualityEvaluationsQueryPost (EvaluationQueryRequest body = null, string expand = null)
        {
             ApiResponse<EvaluationEntityListing> localVarResponse = QualityEvaluationsQueryPostWithHttpInfo(body, expand);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Query evaluations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">evaluator,agent (optional)</param>
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        public ApiResponse< EvaluationEntityListing > QualityEvaluationsQueryPostWithHttpInfo (EvaluationQueryRequest body = null, string expand = null)
        {

            var localVarPath = "/api/v1/quality/evaluations/query";
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
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationEntityListing)));
            
        }

        /// <summary>
        /// Query evaluations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">evaluator,agent (optional)</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationEntityListing> QualityEvaluationsQueryPostAsync (EvaluationQueryRequest body = null, string expand = null)
        {
             ApiResponse<EvaluationEntityListing> localVarResponse = await QualityEvaluationsQueryPostAsyncWithHttpInfo(body, expand);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Query evaluations 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">query (optional)</param>
        /// <param name="expand">evaluator,agent (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> QualityEvaluationsQueryPostAsyncWithHttpInfo (EvaluationQueryRequest body = null, string expand = null)
        {

            var localVarPath = "/api/v1/quality/evaluations/query";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsQueryPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsQueryPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationEntityListing)));
            
        }

        /// <summary>
        /// Score evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>EvaluationScoringSet</returns>
        public EvaluationScoringSet QualityEvaluationsScoringPost (EvaluationFormAndScoringSet body = null)
        {
             ApiResponse<EvaluationScoringSet> localVarResponse = QualityEvaluationsScoringPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Score evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>ApiResponse of EvaluationScoringSet</returns>
        public ApiResponse< EvaluationScoringSet > QualityEvaluationsScoringPostWithHttpInfo (EvaluationFormAndScoringSet body = null)
        {

            var localVarPath = "/api/v1/quality/evaluations/scoring";
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
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsScoringPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsScoringPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationScoringSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationScoringSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationScoringSet)));
            
        }

        /// <summary>
        /// Score evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>Task of EvaluationScoringSet</returns>
        public async System.Threading.Tasks.Task<EvaluationScoringSet> QualityEvaluationsScoringPostAsync (EvaluationFormAndScoringSet body = null)
        {
             ApiResponse<EvaluationScoringSet> localVarResponse = await QualityEvaluationsScoringPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Score evaluation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">evaluationAndScoringSet (optional)</param>
        /// <returns>Task of ApiResponse (EvaluationScoringSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationScoringSet>> QualityEvaluationsScoringPostAsyncWithHttpInfo (EvaluationFormAndScoringSet body = null)
        {

            var localVarPath = "/api/v1/quality/evaluations/scoring";
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
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsScoringPost: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluationsScoringPost: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluationScoringSet>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationScoringSet) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluationScoringSet)));
            
        }

        /// <summary>
        /// Get an evaluator activity 
        /// </summary>
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
        public EvaluatorActivityEntityListing QualityEvaluatorsActivityGet (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)
        {
             ApiResponse<EvaluatorActivityEntityListing> localVarResponse = QualityEvaluatorsActivityGetWithHttpInfo(pageSize, pageNumber, sortBy, expand, startTime, endTime, name, permission, group);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get an evaluator activity 
        /// </summary>
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
        public ApiResponse< EvaluatorActivityEntityListing > QualityEvaluatorsActivityGetWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)
        {

            var localVarPath = "/api/v1/quality/evaluators/activity";
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
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (permission != null) localVarQueryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            if (group != null) localVarQueryParams.Add("group", Configuration.ApiClient.ParameterToString(group)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluatorsActivityGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluatorsActivityGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluatorActivityEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluatorActivityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluatorActivityEntityListing)));
            
        }

        /// <summary>
        /// Get an evaluator activity 
        /// </summary>
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
        /// <returns>Task of EvaluatorActivityEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluatorActivityEntityListing> QualityEvaluatorsActivityGetAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)
        {
             ApiResponse<EvaluatorActivityEntityListing> localVarResponse = await QualityEvaluatorsActivityGetAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, startTime, endTime, name, permission, group);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get an evaluator activity 
        /// </summary>
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
        /// <returns>Task of ApiResponse (EvaluatorActivityEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluatorActivityEntityListing>> QualityEvaluatorsActivityGetAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)
        {

            var localVarPath = "/api/v1/quality/evaluators/activity";
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
            if (startTime != null) localVarQueryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) localVarQueryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (permission != null) localVarQueryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            if (group != null) localVarQueryParams.Add("group", Configuration.ApiClient.ParameterToString(group)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluatorsActivityGet: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling QualityEvaluatorsActivityGet: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EvaluatorActivityEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluatorActivityEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EvaluatorActivityEntityListing)));
            
        }

    }
}
