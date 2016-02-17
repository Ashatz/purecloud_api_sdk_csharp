using System;
using System.IO;
using System.Collections.Generic;
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
        
        /// <summary>
        /// Get all of a Conversation&#39;s Recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready.</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>List&lt;Recording&gt;</returns>
        List<Recording> GetConversationRecordings (string conversationId, int? maxWaitMs = null, string formatId = null);
  
        /// <summary>
        /// Get all of a Conversation&#39;s Recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready.</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>ApiResponse of List&lt;Recording&gt;</returns>
        ApiResponse<List<Recording>> GetConversationRecordingsWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null);

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready.</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of List&lt;Recording&gt;</returns>
        System.Threading.Tasks.Task<List<Recording>> GetConversationRecordingsAsync (string conversationId, int? maxWaitMs = null, string formatId = null);

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready.</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of ApiResponse (List&lt;Recording&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Recording>>> GetConversationRecordingsAsyncWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null);
        
        /// <summary>
        /// Gets a specific recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for completion.</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <param name="download">requesting a download format of the recording</param>
        /// <param name="fileName">the name of the downloaded fileName</param>
        /// <returns></returns>
        void GetConversationRecordingsByRecordingId (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null);
  
        /// <summary>
        /// Gets a specific recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for completion.</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <param name="download">requesting a download format of the recording</param>
        /// <param name="fileName">the name of the downloaded fileName</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> GetConversationRecordingsByRecordingIdWithHttpInfo (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null);

        /// <summary>
        /// Gets a specific recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for completion.</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <param name="download">requesting a download format of the recording</param>
        /// <param name="fileName">the name of the downloaded fileName</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task GetConversationRecordingsByRecordingIdAsync (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null);

        /// <summary>
        /// Gets a specific recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for completion.</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <param name="download">requesting a download format of the recording</param>
        /// <param name="fileName">the name of the downloaded fileName</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> GetConversationRecordingsByRecordingIdAsyncWithHttpInfo (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null);
        
        /// <summary>
        /// Updates the retention records on a recording.
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays=10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated.</param>
        /// <returns></returns>
        void UpdateConversationRecordingsByRecordingId (string conversationId, string recordingId, Recording body, int? restoreDays = null);
  
        /// <summary>
        /// Updates the retention records on a recording.
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays=10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated.</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> UpdateConversationRecordingsByRecordingIdWithHttpInfo (string conversationId, string recordingId, Recording body, int? restoreDays = null);

        /// <summary>
        /// Updates the retention records on a recording.
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays=10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task UpdateConversationRecordingsByRecordingIdAsync (string conversationId, string recordingId, Recording body, int? restoreDays = null);

        /// <summary>
        /// Updates the retention records on a recording.
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays=10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> UpdateConversationRecordingsByRecordingIdAsyncWithHttpInfo (string conversationId, string recordingId, Recording body, int? restoreDays = null);
        
        /// <summary>
        /// Get annotations for recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>List&lt;Annotation&gt;</returns>
        List<Annotation> GetConversationRecordingsByRecordingIdAnnotations (string conversationId, string recordingId);
  
        /// <summary>
        /// Get annotations for recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>ApiResponse of List&lt;Annotation&gt;</returns>
        ApiResponse<List<Annotation>> GetConversationRecordingsByRecordingIdAnnotationsWithHttpInfo (string conversationId, string recordingId);

        /// <summary>
        /// Get annotations for recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of List&lt;Annotation&gt;</returns>
        System.Threading.Tasks.Task<List<Annotation>> GetConversationRecordingsByRecordingIdAnnotationsAsync (string conversationId, string recordingId);

        /// <summary>
        /// Get annotations for recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of ApiResponse (List&lt;Annotation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Annotation>>> GetConversationRecordingsByRecordingIdAnnotationsAsyncWithHttpInfo (string conversationId, string recordingId);
        
        /// <summary>
        /// Create annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Annotation</returns>
        Annotation CreateConversationRecordingsByRecordingIdAnnotations (string conversationId, string recordingId, Annotation body = null);
  
        /// <summary>
        /// Create annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>ApiResponse of Annotation</returns>
        ApiResponse<Annotation> CreateConversationRecordingsByRecordingIdAnnotationsWithHttpInfo (string conversationId, string recordingId, Annotation body = null);

        /// <summary>
        /// Create annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of Annotation</returns>
        System.Threading.Tasks.Task<Annotation> CreateConversationRecordingsByRecordingIdAnnotationsAsync (string conversationId, string recordingId, Annotation body = null);

        /// <summary>
        /// Create annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Annotation>> CreateConversationRecordingsByRecordingIdAnnotationsAsyncWithHttpInfo (string conversationId, string recordingId, Annotation body = null);
        
        /// <summary>
        /// Get annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Annotation</returns>
        Annotation GetConversationRecordingsByRecordingIdAnnotationsByAnnotationId (string conversationId, string recordingId, string annotationId);
  
        /// <summary>
        /// Get annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>ApiResponse of Annotation</returns>
        ApiResponse<Annotation> GetConversationRecordingsByRecordingIdAnnotationsByAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId);

        /// <summary>
        /// Get annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of Annotation</returns>
        System.Threading.Tasks.Task<Annotation> GetConversationRecordingsByRecordingIdAnnotationsByAnnotationIdAsync (string conversationId, string recordingId, string annotationId);

        /// <summary>
        /// Get annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Annotation>> GetConversationRecordingsByRecordingIdAnnotationsByAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId);
        
        /// <summary>
        /// Update annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Annotation</returns>
        Annotation UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationId (string conversationId, string recordingId, string annotationId, Annotation body = null);
  
        /// <summary>
        /// Update annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>ApiResponse of Annotation</returns>
        ApiResponse<Annotation> UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body = null);

        /// <summary>
        /// Update annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of Annotation</returns>
        System.Threading.Tasks.Task<Annotation> UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationIdAsync (string conversationId, string recordingId, string annotationId, Annotation body = null);

        /// <summary>
        /// Update annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Annotation>> UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body = null);
        
        /// <summary>
        /// Delete annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns></returns>
        void DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationId (string conversationId, string recordingId, string annotationId);
  
        /// <summary>
        /// Delete annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId);

        /// <summary>
        /// Delete annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationIdAsync (string conversationId, string recordingId, string annotationId);

        /// <summary>
        /// Delete annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId);
        
        /// <summary>
        /// Gets a list of Agent Activities
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="agentUserId">user id of agent requested</param>
        /// <param name="evaluatorUserId">user id of the evaluator</param>
        /// <param name="name">name</param>
        /// <param name="group">group id</param>
        /// <returns>AgentActivityEntityListing</returns>
        AgentActivityEntityListing GetAgentsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);
  
        /// <summary>
        /// Gets a list of Agent Activities
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="agentUserId">user id of agent requested</param>
        /// <param name="evaluatorUserId">user id of the evaluator</param>
        /// <param name="name">name</param>
        /// <param name="group">group id</param>
        /// <returns>ApiResponse of AgentActivityEntityListing</returns>
        ApiResponse<AgentActivityEntityListing> GetAgentsActivityWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);

        /// <summary>
        /// Gets a list of Agent Activities
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="agentUserId">user id of agent requested</param>
        /// <param name="evaluatorUserId">user id of the evaluator</param>
        /// <param name="name">name</param>
        /// <param name="group">group id</param>
        /// <returns>Task of AgentActivityEntityListing</returns>
        System.Threading.Tasks.Task<AgentActivityEntityListing> GetAgentsActivityAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);

        /// <summary>
        /// Gets a list of Agent Activities
        /// </summary>
        /// <remarks>
        /// Including the number of evaluations and average evaluation score
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="agentUserId">user id of agent requested</param>
        /// <param name="evaluatorUserId">user id of the evaluator</param>
        /// <param name="name">name</param>
        /// <param name="group">group id</param>
        /// <returns>Task of ApiResponse (AgentActivityEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<AgentActivityEntityListing>> GetAgentsActivityAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null);
        
        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="conversationId">conversation id</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <returns>CalibrationEntityListing</returns>
        CalibrationEntityListing GetCalibrations (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null);
  
        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="conversationId">conversation id</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <returns>ApiResponse of CalibrationEntityListing</returns>
        ApiResponse<CalibrationEntityListing> GetCalibrationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null);

        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="conversationId">conversation id</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <returns>Task of CalibrationEntityListing</returns>
        System.Threading.Tasks.Task<CalibrationEntityListing> GetCalibrationsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null);

        /// <summary>
        /// Get the list of calibrations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="conversationId">conversation id</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <returns>Task of ApiResponse (CalibrationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<CalibrationEntityListing>> GetCalibrationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null);
        
        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId</param>
        /// <returns>Calibration</returns>
        Calibration CreateCalibrations (Calibration body = null, string expand = null);
  
        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> CreateCalibrationsWithHttpInfo (Calibration body = null, string expand = null);

        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> CreateCalibrationsAsync (Calibration body = null, string expand = null);

        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> CreateCalibrationsAsyncWithHttpInfo (Calibration body = null, string expand = null);
        
        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Calibration</returns>
        Calibration GetCalibration (string calibrationId, string calibratorId = null);
  
        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> GetCalibrationWithHttpInfo (string calibrationId, string calibratorId = null);

        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> GetCalibrationAsync (string calibrationId, string calibratorId = null);

        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> GetCalibrationAsyncWithHttpInfo (string calibrationId, string calibratorId = null);
        
        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>Calibration</returns>
        Calibration UpdateCalibration (string calibrationId, Calibration body = null);
  
        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> UpdateCalibrationWithHttpInfo (string calibrationId, Calibration body = null);

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> UpdateCalibrationAsync (string calibrationId, Calibration body = null);

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> UpdateCalibrationAsyncWithHttpInfo (string calibrationId, Calibration body = null);
        
        /// <summary>
        /// Delete a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Calibration</returns>
        Calibration DeleteCalibration (string calibrationId, string calibratorId = null);
  
        /// <summary>
        /// Delete a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> DeleteCalibrationWithHttpInfo (string calibrationId, string calibratorId = null);

        /// <summary>
        /// Delete a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> DeleteCalibrationAsync (string calibrationId, string calibratorId = null);

        /// <summary>
        /// Delete a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> DeleteCalibrationAsyncWithHttpInfo (string calibrationId, string calibratorId = null);
        
        /// <summary>
        /// Get audits for conversation or recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="recordingId">id of the recording</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation</param>
        /// <returns>QualityAuditPage</returns>
        QualityAuditPage GetConversationAudits (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null);
  
        /// <summary>
        /// Get audits for conversation or recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="recordingId">id of the recording</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation</param>
        /// <returns>ApiResponse of QualityAuditPage</returns>
        ApiResponse<QualityAuditPage> GetConversationAuditsWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null);

        /// <summary>
        /// Get audits for conversation or recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="recordingId">id of the recording</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation</param>
        /// <returns>Task of QualityAuditPage</returns>
        System.Threading.Tasks.Task<QualityAuditPage> GetConversationAuditsAsync (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null);

        /// <summary>
        /// Get audits for conversation or recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="recordingId">id of the recording</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation</param>
        /// <returns>Task of ApiResponse (QualityAuditPage)</returns>
        System.Threading.Tasks.Task<ApiResponse<QualityAuditPage>> GetConversationAuditsAsyncWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null);
        
        /// <summary>
        /// Create an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Evaluation</returns>
        Evaluation CreateConversationEvaluations (string conversationId, Evaluation body = null, string expand = null);
  
        /// <summary>
        /// Create an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>ApiResponse of Evaluation</returns>
        ApiResponse<Evaluation> CreateConversationEvaluationsWithHttpInfo (string conversationId, Evaluation body = null, string expand = null);

        /// <summary>
        /// Create an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Task of Evaluation</returns>
        System.Threading.Tasks.Task<Evaluation> CreateConversationEvaluationsAsync (string conversationId, Evaluation body = null, string expand = null);

        /// <summary>
        /// Create an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> CreateConversationEvaluationsAsyncWithHttpInfo (string conversationId, Evaluation body = null, string expand = null);
        
        /// <summary>
        /// Get an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm</param>
        /// <returns>Evaluation</returns>
        Evaluation GetConversationEvaluationsByEvaluationId (string conversationId, string evaluationId, string expand = null);
  
        /// <summary>
        /// Get an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm</param>
        /// <returns>ApiResponse of Evaluation</returns>
        ApiResponse<Evaluation> GetConversationEvaluationsByEvaluationIdWithHttpInfo (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Get an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm</param>
        /// <returns>Task of Evaluation</returns>
        System.Threading.Tasks.Task<Evaluation> GetConversationEvaluationsByEvaluationIdAsync (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Get an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> GetConversationEvaluationsByEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null);
        
        /// <summary>
        /// Update an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Evaluation</returns>
        Evaluation UpdateConversationEvaluationsByEvaluationId (string conversationId, string evaluationId, Evaluation body = null, string expand = null);
  
        /// <summary>
        /// Update an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>ApiResponse of Evaluation</returns>
        ApiResponse<Evaluation> UpdateConversationEvaluationsByEvaluationIdWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null);

        /// <summary>
        /// Update an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Task of Evaluation</returns>
        System.Threading.Tasks.Task<Evaluation> UpdateConversationEvaluationsByEvaluationIdAsync (string conversationId, string evaluationId, Evaluation body = null, string expand = null);

        /// <summary>
        /// Update an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> UpdateConversationEvaluationsByEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null);
        
        /// <summary>
        /// Delete an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Evaluation</returns>
        Evaluation DeleteConversationEvaluationsByEvaluationId (string conversationId, string evaluationId, string expand = null);
  
        /// <summary>
        /// Delete an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>ApiResponse of Evaluation</returns>
        ApiResponse<Evaluation> DeleteConversationEvaluationsByEvaluationIdWithHttpInfo (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Delete an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Task of Evaluation</returns>
        System.Threading.Tasks.Task<Evaluation> DeleteConversationEvaluationsByEvaluationIdAsync (string conversationId, string evaluationId, string expand = null);

        /// <summary>
        /// Delete an evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> DeleteConversationEvaluationsByEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null);
        
        /// <summary>
        /// Queries Evaluations and returns a paged list
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="conversationId">conversationId specified</param>
        /// <param name="agentUserId">user id of the agent</param>
        /// <param name="evaluatorUserId">evaluator user id</param>
        /// <param name="queueId">queue id</param>
        /// <param name="startTime">start time of the evaluation query</param>
        /// <param name="endTime">end time of the evaluation query</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished</param>
        /// <param name="isReleased">the evaluation has been released</param>
        /// <param name="agentHasRead">agent has the evaluation</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations</param>
        /// <param name="maximum">maximum</param>
        /// <returns>EvaluationEntityListing</returns>
        EvaluationEntityListing GetEvaluationsQuery (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);
  
        /// <summary>
        /// Queries Evaluations and returns a paged list
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="conversationId">conversationId specified</param>
        /// <param name="agentUserId">user id of the agent</param>
        /// <param name="evaluatorUserId">evaluator user id</param>
        /// <param name="queueId">queue id</param>
        /// <param name="startTime">start time of the evaluation query</param>
        /// <param name="endTime">end time of the evaluation query</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished</param>
        /// <param name="isReleased">the evaluation has been released</param>
        /// <param name="agentHasRead">agent has the evaluation</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations</param>
        /// <param name="maximum">maximum</param>
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        ApiResponse<EvaluationEntityListing> GetEvaluationsQueryWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);

        /// <summary>
        /// Queries Evaluations and returns a paged list
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="conversationId">conversationId specified</param>
        /// <param name="agentUserId">user id of the agent</param>
        /// <param name="evaluatorUserId">evaluator user id</param>
        /// <param name="queueId">queue id</param>
        /// <param name="startTime">start time of the evaluation query</param>
        /// <param name="endTime">end time of the evaluation query</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished</param>
        /// <param name="isReleased">the evaluation has been released</param>
        /// <param name="agentHasRead">agent has the evaluation</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations</param>
        /// <param name="maximum">maximum</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationEntityListing> GetEvaluationsQueryAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);

        /// <summary>
        /// Queries Evaluations and returns a paged list
        /// </summary>
        /// <remarks>
        /// Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="conversationId">conversationId specified</param>
        /// <param name="agentUserId">user id of the agent</param>
        /// <param name="evaluatorUserId">evaluator user id</param>
        /// <param name="queueId">queue id</param>
        /// <param name="startTime">start time of the evaluation query</param>
        /// <param name="endTime">end time of the evaluation query</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished</param>
        /// <param name="isReleased">the evaluation has been released</param>
        /// <param name="agentHasRead">agent has the evaluation</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations</param>
        /// <param name="maximum">maximum</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> GetEvaluationsQueryAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null);
        
        /// <summary>
        /// Query evaluations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">query</param>
        /// <param name="expand">evaluator,agent</param>
        /// <returns>EvaluationEntityListing</returns>
        EvaluationEntityListing CreateEvaluationsQuery (EvaluationQueryRequest body = null, string expand = null);
  
        /// <summary>
        /// Query evaluations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">query</param>
        /// <param name="expand">evaluator,agent</param>
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        ApiResponse<EvaluationEntityListing> CreateEvaluationsQueryWithHttpInfo (EvaluationQueryRequest body = null, string expand = null);

        /// <summary>
        /// Query evaluations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">query</param>
        /// <param name="expand">evaluator,agent</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationEntityListing> CreateEvaluationsQueryAsync (EvaluationQueryRequest body = null, string expand = null);

        /// <summary>
        /// Query evaluations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">query</param>
        /// <param name="expand">evaluator,agent</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> CreateEvaluationsQueryAsyncWithHttpInfo (EvaluationQueryRequest body = null, string expand = null);
        
        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>EvaluationScoringSet</returns>
        EvaluationScoringSet CreateEvaluationsScoring (EvaluationFormAndScoringSet body = null);
  
        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>ApiResponse of EvaluationScoringSet</returns>
        ApiResponse<EvaluationScoringSet> CreateEvaluationsScoringWithHttpInfo (EvaluationFormAndScoringSet body = null);

        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>Task of EvaluationScoringSet</returns>
        System.Threading.Tasks.Task<EvaluationScoringSet> CreateEvaluationsScoringAsync (EvaluationFormAndScoringSet body = null);

        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>Task of ApiResponse (EvaluationScoringSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationScoringSet>> CreateEvaluationsScoringAsyncWithHttpInfo (EvaluationFormAndScoringSet body = null);
        
        /// <summary>
        /// Get an evaluator activity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="name">Evaluator name</param>
        /// <param name="permission">permission strings</param>
        /// <param name="group">group id</param>
        /// <returns>EvaluatorActivityEntityListing</returns>
        EvaluatorActivityEntityListing GetEvaluatorsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null);
  
        /// <summary>
        /// Get an evaluator activity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="name">Evaluator name</param>
        /// <param name="permission">permission strings</param>
        /// <param name="group">group id</param>
        /// <returns>ApiResponse of EvaluatorActivityEntityListing</returns>
        ApiResponse<EvaluatorActivityEntityListing> GetEvaluatorsActivityWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null);

        /// <summary>
        /// Get an evaluator activity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="name">Evaluator name</param>
        /// <param name="permission">permission strings</param>
        /// <param name="group">group id</param>
        /// <returns>Task of EvaluatorActivityEntityListing</returns>
        System.Threading.Tasks.Task<EvaluatorActivityEntityListing> GetEvaluatorsActivityAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null);

        /// <summary>
        /// Get an evaluator activity
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="name">Evaluator name</param>
        /// <param name="permission">permission strings</param>
        /// <param name="group">group id</param>
        /// <returns>Task of ApiResponse (EvaluatorActivityEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluatorActivityEntityListing>> GetEvaluatorsActivityAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null);
        
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
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready.</param> 
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param> 
        /// <returns>List&lt;Recording&gt;</returns>
        public List<Recording> GetConversationRecordings (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
             ApiResponse<List<Recording>> response = GetConversationRecordingsWithHttpInfo(conversationId, maxWaitMs, formatId);
             return response.Data;
        }

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready.</param> 
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param> 
        /// <returns>ApiResponse of List&lt;Recording&gt;</returns>
        public ApiResponse< List<Recording> > GetConversationRecordingsWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationRecordings");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            
            if (maxWaitMs != null) queryParams.Add("maxWaitMs", Configuration.ApiClient.ParameterToString(maxWaitMs)); // query parameter
            if (formatId != null) queryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationRecordings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationRecordings: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<Recording>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Recording>) Configuration.ApiClient.Deserialize(response, typeof(List<Recording>)));
            
        }
    
        /// <summary>
        /// Get all of a Conversation&#39;s Recordings. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready.</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of List&lt;Recording&gt;</returns>
        public async System.Threading.Tasks.Task<List<Recording>> GetConversationRecordingsAsync (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
             ApiResponse<List<Recording>> response = await GetConversationRecordingsAsyncWithHttpInfo(conversationId, maxWaitMs, formatId);
             return response.Data;

        }

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready.</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of ApiResponse (List&lt;Recording&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Recording>>> GetConversationRecordingsAsyncWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationRecordings");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            
            if (maxWaitMs != null) queryParams.Add("maxWaitMs", Configuration.ApiClient.ParameterToString(maxWaitMs)); // query parameter
            if (formatId != null) queryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationRecordings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationRecordings: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<Recording>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Recording>) Configuration.ApiClient.Deserialize(response, typeof(List<Recording>)));
            
        }
        
        /// <summary>
        /// Gets a specific recording. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for completion.</param> 
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param> 
        /// <param name="download">requesting a download format of the recording</param> 
        /// <param name="fileName">the name of the downloaded fileName</param> 
        /// <returns></returns>
        public void GetConversationRecordingsByRecordingId (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null)
        {
             GetConversationRecordingsByRecordingIdWithHttpInfo(conversationId, recordingId, maxWaitMs, formatId, download, fileName);
        }

        /// <summary>
        /// Gets a specific recording. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for completion.</param> 
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param> 
        /// <param name="download">requesting a download format of the recording</param> 
        /// <param name="fileName">the name of the downloaded fileName</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> GetConversationRecordingsByRecordingIdWithHttpInfo (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationRecordingsByRecordingId");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling GetConversationRecordingsByRecordingId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            if (maxWaitMs != null) queryParams.Add("maxWaitMs", Configuration.ApiClient.ParameterToString(maxWaitMs)); // query parameter
            if (formatId != null) queryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
            if (download != null) queryParams.Add("download", Configuration.ApiClient.ParameterToString(download)); // query parameter
            if (fileName != null) queryParams.Add("fileName", Configuration.ApiClient.ParameterToString(fileName)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationRecordingsByRecordingId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationRecordingsByRecordingId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Gets a specific recording. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for completion.</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <param name="download">requesting a download format of the recording</param>
        /// <param name="fileName">the name of the downloaded fileName</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task GetConversationRecordingsByRecordingIdAsync (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null)
        {
             await GetConversationRecordingsByRecordingIdAsyncWithHttpInfo(conversationId, recordingId, maxWaitMs, formatId, download, fileName);

        }

        /// <summary>
        /// Gets a specific recording. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for completion.</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <param name="download">requesting a download format of the recording</param>
        /// <param name="fileName">the name of the downloaded fileName</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetConversationRecordingsByRecordingIdAsyncWithHttpInfo (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationRecordingsByRecordingId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling GetConversationRecordingsByRecordingId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            if (maxWaitMs != null) queryParams.Add("maxWaitMs", Configuration.ApiClient.ParameterToString(maxWaitMs)); // query parameter
            if (formatId != null) queryParams.Add("formatId", Configuration.ApiClient.ParameterToString(formatId)); // query parameter
            if (download != null) queryParams.Add("download", Configuration.ApiClient.ParameterToString(download)); // query parameter
            if (fileName != null) queryParams.Add("fileName", Configuration.ApiClient.ParameterToString(fileName)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationRecordingsByRecordingId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationRecordingsByRecordingId: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays=10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <param name="body">recording</param> 
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated.</param> 
        /// <returns></returns>
        public void UpdateConversationRecordingsByRecordingId (string conversationId, string recordingId, Recording body, int? restoreDays = null)
        {
             UpdateConversationRecordingsByRecordingIdWithHttpInfo(conversationId, recordingId, body, restoreDays);
        }

        /// <summary>
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays=10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <param name="body">recording</param> 
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> UpdateConversationRecordingsByRecordingIdWithHttpInfo (string conversationId, string recordingId, Recording body, int? restoreDays = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling UpdateConversationRecordingsByRecordingId");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling UpdateConversationRecordingsByRecordingId");
            
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateConversationRecordingsByRecordingId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            if (restoreDays != null) queryParams.Add("restoreDays", Configuration.ApiClient.ParameterToString(restoreDays)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateConversationRecordingsByRecordingId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateConversationRecordingsByRecordingId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays=10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task UpdateConversationRecordingsByRecordingIdAsync (string conversationId, string recordingId, Recording body, int? restoreDays = null)
        {
             await UpdateConversationRecordingsByRecordingIdAsyncWithHttpInfo(conversationId, recordingId, body, restoreDays);

        }

        /// <summary>
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays=10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> UpdateConversationRecordingsByRecordingIdAsyncWithHttpInfo (string conversationId, string recordingId, Recording body, int? restoreDays = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling UpdateConversationRecordingsByRecordingId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling UpdateConversationRecordingsByRecordingId");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling UpdateConversationRecordingsByRecordingId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            if (restoreDays != null) queryParams.Add("restoreDays", Configuration.ApiClient.ParameterToString(restoreDays)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateConversationRecordingsByRecordingId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateConversationRecordingsByRecordingId: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Get annotations for recording 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <returns>List&lt;Annotation&gt;</returns>
        public List<Annotation> GetConversationRecordingsByRecordingIdAnnotations (string conversationId, string recordingId)
        {
             ApiResponse<List<Annotation>> response = GetConversationRecordingsByRecordingIdAnnotationsWithHttpInfo(conversationId, recordingId);
             return response.Data;
        }

        /// <summary>
        /// Get annotations for recording 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <returns>ApiResponse of List&lt;Annotation&gt;</returns>
        public ApiResponse< List<Annotation> > GetConversationRecordingsByRecordingIdAnnotationsWithHttpInfo (string conversationId, string recordingId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationRecordingsByRecordingIdAnnotations");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling GetConversationRecordingsByRecordingIdAnnotations");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationRecordingsByRecordingIdAnnotations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationRecordingsByRecordingIdAnnotations: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<List<Annotation>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Annotation>) Configuration.ApiClient.Deserialize(response, typeof(List<Annotation>)));
            
        }
    
        /// <summary>
        /// Get annotations for recording 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of List&lt;Annotation&gt;</returns>
        public async System.Threading.Tasks.Task<List<Annotation>> GetConversationRecordingsByRecordingIdAnnotationsAsync (string conversationId, string recordingId)
        {
             ApiResponse<List<Annotation>> response = await GetConversationRecordingsByRecordingIdAnnotationsAsyncWithHttpInfo(conversationId, recordingId);
             return response.Data;

        }

        /// <summary>
        /// Get annotations for recording 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of ApiResponse (List&lt;Annotation&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Annotation>>> GetConversationRecordingsByRecordingIdAnnotationsAsyncWithHttpInfo (string conversationId, string recordingId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationRecordingsByRecordingIdAnnotations");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling GetConversationRecordingsByRecordingIdAnnotations");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationRecordingsByRecordingIdAnnotations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationRecordingsByRecordingIdAnnotations: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<List<Annotation>>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Annotation>) Configuration.ApiClient.Deserialize(response, typeof(List<Annotation>)));
            
        }
        
        /// <summary>
        /// Create annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <param name="body">annotation</param> 
        /// <returns>Annotation</returns>
        public Annotation CreateConversationRecordingsByRecordingIdAnnotations (string conversationId, string recordingId, Annotation body = null)
        {
             ApiResponse<Annotation> response = CreateConversationRecordingsByRecordingIdAnnotationsWithHttpInfo(conversationId, recordingId, body);
             return response.Data;
        }

        /// <summary>
        /// Create annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <param name="body">annotation</param> 
        /// <returns>ApiResponse of Annotation</returns>
        public ApiResponse< Annotation > CreateConversationRecordingsByRecordingIdAnnotationsWithHttpInfo (string conversationId, string recordingId, Annotation body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling CreateConversationRecordingsByRecordingIdAnnotations");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling CreateConversationRecordingsByRecordingIdAnnotations");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateConversationRecordingsByRecordingIdAnnotations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateConversationRecordingsByRecordingIdAnnotations: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Annotation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(response, typeof(Annotation)));
            
        }
    
        /// <summary>
        /// Create annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of Annotation</returns>
        public async System.Threading.Tasks.Task<Annotation> CreateConversationRecordingsByRecordingIdAnnotationsAsync (string conversationId, string recordingId, Annotation body = null)
        {
             ApiResponse<Annotation> response = await CreateConversationRecordingsByRecordingIdAnnotationsAsyncWithHttpInfo(conversationId, recordingId, body);
             return response.Data;

        }

        /// <summary>
        /// Create annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Annotation>> CreateConversationRecordingsByRecordingIdAnnotationsAsyncWithHttpInfo (string conversationId, string recordingId, Annotation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling CreateConversationRecordingsByRecordingIdAnnotations");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling CreateConversationRecordingsByRecordingIdAnnotations");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateConversationRecordingsByRecordingIdAnnotations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateConversationRecordingsByRecordingIdAnnotations: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Annotation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(response, typeof(Annotation)));
            
        }
        
        /// <summary>
        /// Get annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <param name="annotationId">Annotation ID</param> 
        /// <returns>Annotation</returns>
        public Annotation GetConversationRecordingsByRecordingIdAnnotationsByAnnotationId (string conversationId, string recordingId, string annotationId)
        {
             ApiResponse<Annotation> response = GetConversationRecordingsByRecordingIdAnnotationsByAnnotationIdWithHttpInfo(conversationId, recordingId, annotationId);
             return response.Data;
        }

        /// <summary>
        /// Get annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <param name="annotationId">Annotation ID</param> 
        /// <returns>ApiResponse of Annotation</returns>
        public ApiResponse< Annotation > GetConversationRecordingsByRecordingIdAnnotationsByAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling GetConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            
            // verify the required parameter 'annotationId' is set
            if (annotationId == null) throw new ApiException(400, "Missing required parameter 'annotationId' when calling GetConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) pathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationRecordingsByRecordingIdAnnotationsByAnnotationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationRecordingsByRecordingIdAnnotationsByAnnotationId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Annotation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(response, typeof(Annotation)));
            
        }
    
        /// <summary>
        /// Get annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of Annotation</returns>
        public async System.Threading.Tasks.Task<Annotation> GetConversationRecordingsByRecordingIdAnnotationsByAnnotationIdAsync (string conversationId, string recordingId, string annotationId)
        {
             ApiResponse<Annotation> response = await GetConversationRecordingsByRecordingIdAnnotationsByAnnotationIdAsyncWithHttpInfo(conversationId, recordingId, annotationId);
             return response.Data;

        }

        /// <summary>
        /// Get annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Annotation>> GetConversationRecordingsByRecordingIdAnnotationsByAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling GetConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null) throw new ApiException(400, "Missing required parameter 'annotationId' when calling GetConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) pathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationRecordingsByRecordingIdAnnotationsByAnnotationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationRecordingsByRecordingIdAnnotationsByAnnotationId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Annotation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(response, typeof(Annotation)));
            
        }
        
        /// <summary>
        /// Update annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <param name="annotationId">Annotation ID</param> 
        /// <param name="body">annotation</param> 
        /// <returns>Annotation</returns>
        public Annotation UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationId (string conversationId, string recordingId, string annotationId, Annotation body = null)
        {
             ApiResponse<Annotation> response = UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationIdWithHttpInfo(conversationId, recordingId, annotationId, body);
             return response.Data;
        }

        /// <summary>
        /// Update annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <param name="annotationId">Annotation ID</param> 
        /// <param name="body">annotation</param> 
        /// <returns>ApiResponse of Annotation</returns>
        public ApiResponse< Annotation > UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            
            // verify the required parameter 'annotationId' is set
            if (annotationId == null) throw new ApiException(400, "Missing required parameter 'annotationId' when calling UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) pathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Annotation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(response, typeof(Annotation)));
            
        }
    
        /// <summary>
        /// Update annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of Annotation</returns>
        public async System.Threading.Tasks.Task<Annotation> UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationIdAsync (string conversationId, string recordingId, string annotationId, Annotation body = null)
        {
             ApiResponse<Annotation> response = await UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationIdAsyncWithHttpInfo(conversationId, recordingId, annotationId, body);
             return response.Data;

        }

        /// <summary>
        /// Update annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Annotation>> UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null) throw new ApiException(400, "Missing required parameter 'annotationId' when calling UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) pathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateConversationRecordingsByRecordingIdAnnotationsByAnnotationId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Annotation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(response, typeof(Annotation)));
            
        }
        
        /// <summary>
        /// Delete annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <param name="annotationId">Annotation ID</param> 
        /// <returns></returns>
        public void DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationId (string conversationId, string recordingId, string annotationId)
        {
             DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationIdWithHttpInfo(conversationId, recordingId, annotationId);
        }

        /// <summary>
        /// Delete annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <param name="annotationId">Annotation ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            
            // verify the required parameter 'annotationId' is set
            if (annotationId == null) throw new ApiException(400, "Missing required parameter 'annotationId' when calling DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) pathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationId: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        /// Delete annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationIdAsync (string conversationId, string recordingId, string annotationId)
        {
             await DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationIdAsyncWithHttpInfo(conversationId, recordingId, annotationId);

        }

        /// <summary>
        /// Delete annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null) throw new ApiException(400, "Missing required parameter 'annotationId' when calling DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) pathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter
            
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteConversationRecordingsByRecordingIdAnnotationsByAnnotationId: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        /// Gets a list of Agent Activities Including the number of evaluations and average evaluation score
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="agentUserId">user id of agent requested</param> 
        /// <param name="evaluatorUserId">user id of the evaluator</param> 
        /// <param name="name">name</param> 
        /// <param name="group">group id</param> 
        /// <returns>AgentActivityEntityListing</returns>
        public AgentActivityEntityListing GetAgentsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {
             ApiResponse<AgentActivityEntityListing> response = GetAgentsActivityWithHttpInfo(pageSize, pageNumber, sortBy, expand, startTime, endTime, agentUserId, evaluatorUserId, name, group);
             return response.Data;
        }

        /// <summary>
        /// Gets a list of Agent Activities Including the number of evaluations and average evaluation score
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="agentUserId">user id of agent requested</param> 
        /// <param name="evaluatorUserId">user id of the evaluator</param> 
        /// <param name="name">name</param> 
        /// <param name="group">group id</param> 
        /// <returns>ApiResponse of AgentActivityEntityListing</returns>
        public ApiResponse< AgentActivityEntityListing > GetAgentsActivityWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {
            
    
            var path_ = "/api/v1/quality/agents/activity";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (startTime != null) queryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (agentUserId != null) queryParams.Add("agentUserId", Configuration.ApiClient.ParameterToString(agentUserId)); // query parameter
            if (evaluatorUserId != null) queryParams.Add("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (group != null) queryParams.Add("group", Configuration.ApiClient.ParameterToString(group)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAgentsActivity: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAgentsActivity: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AgentActivityEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AgentActivityEntityListing) Configuration.ApiClient.Deserialize(response, typeof(AgentActivityEntityListing)));
            
        }
    
        /// <summary>
        /// Gets a list of Agent Activities Including the number of evaluations and average evaluation score
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="agentUserId">user id of agent requested</param>
        /// <param name="evaluatorUserId">user id of the evaluator</param>
        /// <param name="name">name</param>
        /// <param name="group">group id</param>
        /// <returns>Task of AgentActivityEntityListing</returns>
        public async System.Threading.Tasks.Task<AgentActivityEntityListing> GetAgentsActivityAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {
             ApiResponse<AgentActivityEntityListing> response = await GetAgentsActivityAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, startTime, endTime, agentUserId, evaluatorUserId, name, group);
             return response.Data;

        }

        /// <summary>
        /// Gets a list of Agent Activities Including the number of evaluations and average evaluation score
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="startTime">Start time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">End time of agent activity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="agentUserId">user id of agent requested</param>
        /// <param name="evaluatorUserId">user id of the evaluator</param>
        /// <param name="name">name</param>
        /// <param name="group">group id</param>
        /// <returns>Task of ApiResponse (AgentActivityEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AgentActivityEntityListing>> GetAgentsActivityAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, List<string> agentUserId = null, string evaluatorUserId = null, string name = null, string group = null)
        {
            
    
            var path_ = "/api/v1/quality/agents/activity";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (startTime != null) queryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (agentUserId != null) queryParams.Add("agentUserId", Configuration.ApiClient.ParameterToString(agentUserId)); // query parameter
            if (evaluatorUserId != null) queryParams.Add("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (group != null) queryParams.Add("group", Configuration.ApiClient.ParameterToString(group)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAgentsActivity: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAgentsActivity: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AgentActivityEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AgentActivityEntityListing) Configuration.ApiClient.Deserialize(response, typeof(AgentActivityEntityListing)));
            
        }
        
        /// <summary>
        /// Get the list of calibrations 
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="conversationId">conversation id</param> 
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="calibratorId">user id of calibrator</param> 
        /// <returns>CalibrationEntityListing</returns>
        public CalibrationEntityListing GetCalibrations (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null)
        {
             ApiResponse<CalibrationEntityListing> response = GetCalibrationsWithHttpInfo(pageSize, pageNumber, sortBy, expand, conversationId, startTime, endTime, calibratorId);
             return response.Data;
        }

        /// <summary>
        /// Get the list of calibrations 
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="conversationId">conversation id</param> 
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="calibratorId">user id of calibrator</param> 
        /// <returns>ApiResponse of CalibrationEntityListing</returns>
        public ApiResponse< CalibrationEntityListing > GetCalibrationsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null)
        {
            
    
            var path_ = "/api/v1/quality/calibrations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (conversationId != null) queryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            if (startTime != null) queryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (calibratorId != null) queryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCalibrations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCalibrations: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<CalibrationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CalibrationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CalibrationEntityListing)));
            
        }
    
        /// <summary>
        /// Get the list of calibrations 
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="conversationId">conversation id</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <returns>Task of CalibrationEntityListing</returns>
        public async System.Threading.Tasks.Task<CalibrationEntityListing> GetCalibrationsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null)
        {
             ApiResponse<CalibrationEntityListing> response = await GetCalibrationsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, conversationId, startTime, endTime, calibratorId);
             return response.Data;

        }

        /// <summary>
        /// Get the list of calibrations 
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="conversationId">conversation id</param>
        /// <param name="startTime">Beginning of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">end of the calibration query. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="calibratorId">user id of calibrator</param>
        /// <returns>Task of ApiResponse (CalibrationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CalibrationEntityListing>> GetCalibrationsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, DateTime? startTime = null, DateTime? endTime = null, string calibratorId = null)
        {
            
    
            var path_ = "/api/v1/quality/calibrations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (conversationId != null) queryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            if (startTime != null) queryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (calibratorId != null) queryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCalibrations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCalibrations: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<CalibrationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CalibrationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(CalibrationEntityListing)));
            
        }
        
        /// <summary>
        /// Create a calibration 
        /// </summary>
        /// <param name="body">calibration</param> 
        /// <param name="expand">calibratorId</param> 
        /// <returns>Calibration</returns>
        public Calibration CreateCalibrations (Calibration body = null, string expand = null)
        {
             ApiResponse<Calibration> response = CreateCalibrationsWithHttpInfo(body, expand);
             return response.Data;
        }

        /// <summary>
        /// Create a calibration 
        /// </summary>
        /// <param name="body">calibration</param> 
        /// <param name="expand">calibratorId</param> 
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > CreateCalibrationsWithHttpInfo (Calibration body = null, string expand = null)
        {
            
    
            var path_ = "/api/v1/quality/calibrations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateCalibrations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateCalibrations: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Calibration>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(response, typeof(Calibration)));
            
        }
    
        /// <summary>
        /// Create a calibration 
        /// </summary>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> CreateCalibrationsAsync (Calibration body = null, string expand = null)
        {
             ApiResponse<Calibration> response = await CreateCalibrationsAsyncWithHttpInfo(body, expand);
             return response.Data;

        }

        /// <summary>
        /// Create a calibration 
        /// </summary>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> CreateCalibrationsAsyncWithHttpInfo (Calibration body = null, string expand = null)
        {
            
    
            var path_ = "/api/v1/quality/calibrations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateCalibrations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateCalibrations: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Calibration>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(response, typeof(Calibration)));
            
        }
        
        /// <summary>
        /// Get a calibration by id. 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param> 
        /// <param name="calibratorId">calibratorId</param> 
        /// <returns>Calibration</returns>
        public Calibration GetCalibration (string calibrationId, string calibratorId = null)
        {
             ApiResponse<Calibration> response = GetCalibrationWithHttpInfo(calibrationId, calibratorId);
             return response.Data;
        }

        /// <summary>
        /// Get a calibration by id. 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param> 
        /// <param name="calibratorId">calibratorId</param> 
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > GetCalibrationWithHttpInfo (string calibrationId, string calibratorId = null)
        {
            
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null) throw new ApiException(400, "Missing required parameter 'calibrationId' when calling GetCalibration");
            
    
            var path_ = "/api/v1/quality/calibrations/{calibrationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (calibrationId != null) pathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            
            if (calibratorId != null) queryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCalibration: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCalibration: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Calibration>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(response, typeof(Calibration)));
            
        }
    
        /// <summary>
        /// Get a calibration by id. 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> GetCalibrationAsync (string calibrationId, string calibratorId = null)
        {
             ApiResponse<Calibration> response = await GetCalibrationAsyncWithHttpInfo(calibrationId, calibratorId);
             return response.Data;

        }

        /// <summary>
        /// Get a calibration by id. 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> GetCalibrationAsyncWithHttpInfo (string calibrationId, string calibratorId = null)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null) throw new ApiException(400, "Missing required parameter 'calibrationId' when calling GetCalibration");
            
    
            var path_ = "/api/v1/quality/calibrations/{calibrationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (calibrationId != null) pathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            
            if (calibratorId != null) queryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCalibration: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCalibration: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Calibration>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(response, typeof(Calibration)));
            
        }
        
        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param> 
        /// <param name="body">Calibration</param> 
        /// <returns>Calibration</returns>
        public Calibration UpdateCalibration (string calibrationId, Calibration body = null)
        {
             ApiResponse<Calibration> response = UpdateCalibrationWithHttpInfo(calibrationId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param> 
        /// <param name="body">Calibration</param> 
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > UpdateCalibrationWithHttpInfo (string calibrationId, Calibration body = null)
        {
            
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null) throw new ApiException(400, "Missing required parameter 'calibrationId' when calling UpdateCalibration");
            
    
            var path_ = "/api/v1/quality/calibrations/{calibrationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (calibrationId != null) pathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateCalibration: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateCalibration: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Calibration>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(response, typeof(Calibration)));
            
        }
    
        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> UpdateCalibrationAsync (string calibrationId, Calibration body = null)
        {
             ApiResponse<Calibration> response = await UpdateCalibrationAsyncWithHttpInfo(calibrationId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> UpdateCalibrationAsyncWithHttpInfo (string calibrationId, Calibration body = null)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null) throw new ApiException(400, "Missing required parameter 'calibrationId' when calling UpdateCalibration");
            
    
            var path_ = "/api/v1/quality/calibrations/{calibrationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (calibrationId != null) pathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateCalibration: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateCalibration: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Calibration>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(response, typeof(Calibration)));
            
        }
        
        /// <summary>
        /// Delete a calibration by id. 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param> 
        /// <param name="calibratorId">calibratorId</param> 
        /// <returns>Calibration</returns>
        public Calibration DeleteCalibration (string calibrationId, string calibratorId = null)
        {
             ApiResponse<Calibration> response = DeleteCalibrationWithHttpInfo(calibrationId, calibratorId);
             return response.Data;
        }

        /// <summary>
        /// Delete a calibration by id. 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param> 
        /// <param name="calibratorId">calibratorId</param> 
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > DeleteCalibrationWithHttpInfo (string calibrationId, string calibratorId = null)
        {
            
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null) throw new ApiException(400, "Missing required parameter 'calibrationId' when calling DeleteCalibration");
            
    
            var path_ = "/api/v1/quality/calibrations/{calibrationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (calibrationId != null) pathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            
            if (calibratorId != null) queryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteCalibration: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteCalibration: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Calibration>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(response, typeof(Calibration)));
            
        }
    
        /// <summary>
        /// Delete a calibration by id. 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        public async System.Threading.Tasks.Task<Calibration> DeleteCalibrationAsync (string calibrationId, string calibratorId = null)
        {
             ApiResponse<Calibration> response = await DeleteCalibrationAsyncWithHttpInfo(calibrationId, calibratorId);
             return response.Data;

        }

        /// <summary>
        /// Delete a calibration by id. 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> DeleteCalibrationAsyncWithHttpInfo (string calibrationId, string calibratorId = null)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null) throw new ApiException(400, "Missing required parameter 'calibrationId' when calling DeleteCalibration");
            
    
            var path_ = "/api/v1/quality/calibrations/{calibrationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (calibrationId != null) pathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            
            if (calibratorId != null) queryParams.Add("calibratorId", Configuration.ApiClient.ParameterToString(calibratorId)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteCalibration: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteCalibration: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Calibration>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Calibration) Configuration.ApiClient.Deserialize(response, typeof(Calibration)));
            
        }
        
        /// <summary>
        /// Get audits for conversation or recording 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="recordingId">id of the recording</param> 
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation</param> 
        /// <returns>QualityAuditPage</returns>
        public QualityAuditPage GetConversationAudits (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)
        {
             ApiResponse<QualityAuditPage> response = GetConversationAuditsWithHttpInfo(conversationId, pageSize, pageNumber, sortBy, expand, recordingId, entityType);
             return response.Data;
        }

        /// <summary>
        /// Get audits for conversation or recording 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="recordingId">id of the recording</param> 
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation</param> 
        /// <returns>ApiResponse of QualityAuditPage</returns>
        public ApiResponse< QualityAuditPage > GetConversationAuditsWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationAudits");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/audits";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (recordingId != null) queryParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // query parameter
            if (entityType != null) queryParams.Add("entityType", Configuration.ApiClient.ParameterToString(entityType)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationAudits: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationAudits: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<QualityAuditPage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QualityAuditPage) Configuration.ApiClient.Deserialize(response, typeof(QualityAuditPage)));
            
        }
    
        /// <summary>
        /// Get audits for conversation or recording 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="recordingId">id of the recording</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation</param>
        /// <returns>Task of QualityAuditPage</returns>
        public async System.Threading.Tasks.Task<QualityAuditPage> GetConversationAuditsAsync (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)
        {
             ApiResponse<QualityAuditPage> response = await GetConversationAuditsAsyncWithHttpInfo(conversationId, pageSize, pageNumber, sortBy, expand, recordingId, entityType);
             return response.Data;

        }

        /// <summary>
        /// Get audits for conversation or recording 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="recordingId">id of the recording</param>
        /// <param name="entityType">entity type options: Recording, Calibration, Evaluation, Annotation</param>
        /// <returns>Task of ApiResponse (QualityAuditPage)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<QualityAuditPage>> GetConversationAuditsAsyncWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationAudits");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/audits";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (recordingId != null) queryParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // query parameter
            if (entityType != null) queryParams.Add("entityType", Configuration.ApiClient.ParameterToString(entityType)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationAudits: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationAudits: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<QualityAuditPage>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (QualityAuditPage) Configuration.ApiClient.Deserialize(response, typeof(QualityAuditPage)));
            
        }
        
        /// <summary>
        /// Create an evaluation 
        /// </summary>
        /// <param name="conversationId"></param> 
        /// <param name="body">evaluation</param> 
        /// <param name="expand">evaluatorId</param> 
        /// <returns>Evaluation</returns>
        public Evaluation CreateConversationEvaluations (string conversationId, Evaluation body = null, string expand = null)
        {
             ApiResponse<Evaluation> response = CreateConversationEvaluationsWithHttpInfo(conversationId, body, expand);
             return response.Data;
        }

        /// <summary>
        /// Create an evaluation 
        /// </summary>
        /// <param name="conversationId"></param> 
        /// <param name="body">evaluation</param> 
        /// <param name="expand">evaluatorId</param> 
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > CreateConversationEvaluationsWithHttpInfo (string conversationId, Evaluation body = null, string expand = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling CreateConversationEvaluations");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/evaluations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateConversationEvaluations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateConversationEvaluations: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Evaluation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(response, typeof(Evaluation)));
            
        }
    
        /// <summary>
        /// Create an evaluation 
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Task of Evaluation</returns>
        public async System.Threading.Tasks.Task<Evaluation> CreateConversationEvaluationsAsync (string conversationId, Evaluation body = null, string expand = null)
        {
             ApiResponse<Evaluation> response = await CreateConversationEvaluationsAsyncWithHttpInfo(conversationId, body, expand);
             return response.Data;

        }

        /// <summary>
        /// Create an evaluation 
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> CreateConversationEvaluationsAsyncWithHttpInfo (string conversationId, Evaluation body = null, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling CreateConversationEvaluations");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/evaluations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateConversationEvaluations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateConversationEvaluations: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Evaluation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(response, typeof(Evaluation)));
            
        }
        
        /// <summary>
        /// Get an evaluation 
        /// </summary>
        /// <param name="conversationId"></param> 
        /// <param name="evaluationId"></param> 
        /// <param name="expand">agent, evaluator, evaluationForm</param> 
        /// <returns>Evaluation</returns>
        public Evaluation GetConversationEvaluationsByEvaluationId (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> response = GetConversationEvaluationsByEvaluationIdWithHttpInfo(conversationId, evaluationId, expand);
             return response.Data;
        }

        /// <summary>
        /// Get an evaluation 
        /// </summary>
        /// <param name="conversationId"></param> 
        /// <param name="evaluationId"></param> 
        /// <param name="expand">agent, evaluator, evaluationForm</param> 
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > GetConversationEvaluationsByEvaluationIdWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationEvaluationsByEvaluationId");
            
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null) throw new ApiException(400, "Missing required parameter 'evaluationId' when calling GetConversationEvaluationsByEvaluationId");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (evaluationId != null) pathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationEvaluationsByEvaluationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationEvaluationsByEvaluationId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Evaluation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(response, typeof(Evaluation)));
            
        }
    
        /// <summary>
        /// Get an evaluation 
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm</param>
        /// <returns>Task of Evaluation</returns>
        public async System.Threading.Tasks.Task<Evaluation> GetConversationEvaluationsByEvaluationIdAsync (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> response = await GetConversationEvaluationsByEvaluationIdAsyncWithHttpInfo(conversationId, evaluationId, expand);
             return response.Data;

        }

        /// <summary>
        /// Get an evaluation 
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> GetConversationEvaluationsByEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationEvaluationsByEvaluationId");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null) throw new ApiException(400, "Missing required parameter 'evaluationId' when calling GetConversationEvaluationsByEvaluationId");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (evaluationId != null) pathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationEvaluationsByEvaluationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationEvaluationsByEvaluationId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Evaluation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(response, typeof(Evaluation)));
            
        }
        
        /// <summary>
        /// Update an evaluation 
        /// </summary>
        /// <param name="conversationId"></param> 
        /// <param name="evaluationId"></param> 
        /// <param name="body">evaluation</param> 
        /// <param name="expand">evaluatorId</param> 
        /// <returns>Evaluation</returns>
        public Evaluation UpdateConversationEvaluationsByEvaluationId (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
             ApiResponse<Evaluation> response = UpdateConversationEvaluationsByEvaluationIdWithHttpInfo(conversationId, evaluationId, body, expand);
             return response.Data;
        }

        /// <summary>
        /// Update an evaluation 
        /// </summary>
        /// <param name="conversationId"></param> 
        /// <param name="evaluationId"></param> 
        /// <param name="body">evaluation</param> 
        /// <param name="expand">evaluatorId</param> 
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > UpdateConversationEvaluationsByEvaluationIdWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling UpdateConversationEvaluationsByEvaluationId");
            
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null) throw new ApiException(400, "Missing required parameter 'evaluationId' when calling UpdateConversationEvaluationsByEvaluationId");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (evaluationId != null) pathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateConversationEvaluationsByEvaluationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateConversationEvaluationsByEvaluationId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Evaluation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(response, typeof(Evaluation)));
            
        }
    
        /// <summary>
        /// Update an evaluation 
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Task of Evaluation</returns>
        public async System.Threading.Tasks.Task<Evaluation> UpdateConversationEvaluationsByEvaluationIdAsync (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
             ApiResponse<Evaluation> response = await UpdateConversationEvaluationsByEvaluationIdAsyncWithHttpInfo(conversationId, evaluationId, body, expand);
             return response.Data;

        }

        /// <summary>
        /// Update an evaluation 
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> UpdateConversationEvaluationsByEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling UpdateConversationEvaluationsByEvaluationId");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null) throw new ApiException(400, "Missing required parameter 'evaluationId' when calling UpdateConversationEvaluationsByEvaluationId");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (evaluationId != null) pathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling UpdateConversationEvaluationsByEvaluationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling UpdateConversationEvaluationsByEvaluationId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Evaluation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(response, typeof(Evaluation)));
            
        }
        
        /// <summary>
        /// Delete an evaluation 
        /// </summary>
        /// <param name="conversationId"></param> 
        /// <param name="evaluationId"></param> 
        /// <param name="expand">evaluatorId</param> 
        /// <returns>Evaluation</returns>
        public Evaluation DeleteConversationEvaluationsByEvaluationId (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> response = DeleteConversationEvaluationsByEvaluationIdWithHttpInfo(conversationId, evaluationId, expand);
             return response.Data;
        }

        /// <summary>
        /// Delete an evaluation 
        /// </summary>
        /// <param name="conversationId"></param> 
        /// <param name="evaluationId"></param> 
        /// <param name="expand">evaluatorId</param> 
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > DeleteConversationEvaluationsByEvaluationIdWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling DeleteConversationEvaluationsByEvaluationId");
            
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null) throw new ApiException(400, "Missing required parameter 'evaluationId' when calling DeleteConversationEvaluationsByEvaluationId");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (evaluationId != null) pathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteConversationEvaluationsByEvaluationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteConversationEvaluationsByEvaluationId: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<Evaluation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(response, typeof(Evaluation)));
            
        }
    
        /// <summary>
        /// Delete an evaluation 
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Task of Evaluation</returns>
        public async System.Threading.Tasks.Task<Evaluation> DeleteConversationEvaluationsByEvaluationIdAsync (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> response = await DeleteConversationEvaluationsByEvaluationIdAsyncWithHttpInfo(conversationId, evaluationId, expand);
             return response.Data;

        }

        /// <summary>
        /// Delete an evaluation 
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> DeleteConversationEvaluationsByEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling DeleteConversationEvaluationsByEvaluationId");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null) throw new ApiException(400, "Missing required parameter 'evaluationId' when calling DeleteConversationEvaluationsByEvaluationId");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (evaluationId != null) pathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteConversationEvaluationsByEvaluationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteConversationEvaluationsByEvaluationId: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<Evaluation>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Evaluation) Configuration.ApiClient.Deserialize(response, typeof(Evaluation)));
            
        }
        
        /// <summary>
        /// Queries Evaluations and returns a paged list Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="conversationId">conversationId specified</param> 
        /// <param name="agentUserId">user id of the agent</param> 
        /// <param name="evaluatorUserId">evaluator user id</param> 
        /// <param name="queueId">queue id</param> 
        /// <param name="startTime">start time of the evaluation query</param> 
        /// <param name="endTime">end time of the evaluation query</param> 
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished</param> 
        /// <param name="isReleased">the evaluation has been released</param> 
        /// <param name="agentHasRead">agent has the evaluation</param> 
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations</param> 
        /// <param name="maximum">maximum</param> 
        /// <returns>EvaluationEntityListing</returns>
        public EvaluationEntityListing GetEvaluationsQuery (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
        {
             ApiResponse<EvaluationEntityListing> response = GetEvaluationsQueryWithHttpInfo(pageSize, pageNumber, sortBy, expand, conversationId, agentUserId, evaluatorUserId, queueId, startTime, endTime, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum);
             return response.Data;
        }

        /// <summary>
        /// Queries Evaluations and returns a paged list Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="conversationId">conversationId specified</param> 
        /// <param name="agentUserId">user id of the agent</param> 
        /// <param name="evaluatorUserId">evaluator user id</param> 
        /// <param name="queueId">queue id</param> 
        /// <param name="startTime">start time of the evaluation query</param> 
        /// <param name="endTime">end time of the evaluation query</param> 
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished</param> 
        /// <param name="isReleased">the evaluation has been released</param> 
        /// <param name="agentHasRead">agent has the evaluation</param> 
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations</param> 
        /// <param name="maximum">maximum</param> 
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        public ApiResponse< EvaluationEntityListing > GetEvaluationsQueryWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
        {
            
    
            var path_ = "/api/v1/quality/evaluations/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (conversationId != null) queryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            if (agentUserId != null) queryParams.Add("agentUserId", Configuration.ApiClient.ParameterToString(agentUserId)); // query parameter
            if (evaluatorUserId != null) queryParams.Add("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)); // query parameter
            if (queueId != null) queryParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // query parameter
            if (startTime != null) queryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (evaluationState != null) queryParams.Add("evaluationState", Configuration.ApiClient.ParameterToString(evaluationState)); // query parameter
            if (isReleased != null) queryParams.Add("isReleased", Configuration.ApiClient.ParameterToString(isReleased)); // query parameter
            if (agentHasRead != null) queryParams.Add("agentHasRead", Configuration.ApiClient.ParameterToString(agentHasRead)); // query parameter
            if (expandAnswerTotalScores != null) queryParams.Add("expandAnswerTotalScores", Configuration.ApiClient.ParameterToString(expandAnswerTotalScores)); // query parameter
            if (maximum != null) queryParams.Add("maximum", Configuration.ApiClient.ParameterToString(maximum)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetEvaluationsQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEvaluationsQuery: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EvaluationEntityListing)));
            
        }
    
        /// <summary>
        /// Queries Evaluations and returns a paged list Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="conversationId">conversationId specified</param>
        /// <param name="agentUserId">user id of the agent</param>
        /// <param name="evaluatorUserId">evaluator user id</param>
        /// <param name="queueId">queue id</param>
        /// <param name="startTime">start time of the evaluation query</param>
        /// <param name="endTime">end time of the evaluation query</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished</param>
        /// <param name="isReleased">the evaluation has been released</param>
        /// <param name="agentHasRead">agent has the evaluation</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations</param>
        /// <param name="maximum">maximum</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationEntityListing> GetEvaluationsQueryAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
        {
             ApiResponse<EvaluationEntityListing> response = await GetEvaluationsQueryAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, conversationId, agentUserId, evaluatorUserId, queueId, startTime, endTime, evaluationState, isReleased, agentHasRead, expandAnswerTotalScores, maximum);
             return response.Data;

        }

        /// <summary>
        /// Queries Evaluations and returns a paged list Query params must include one of conversationId, evaluatorUserId, or agentUserId
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="conversationId">conversationId specified</param>
        /// <param name="agentUserId">user id of the agent</param>
        /// <param name="evaluatorUserId">evaluator user id</param>
        /// <param name="queueId">queue id</param>
        /// <param name="startTime">start time of the evaluation query</param>
        /// <param name="endTime">end time of the evaluation query</param>
        /// <param name="evaluationState">evaluation state options: Pending, InProgress, Finished</param>
        /// <param name="isReleased">the evaluation has been released</param>
        /// <param name="agentHasRead">agent has the evaluation</param>
        /// <param name="expandAnswerTotalScores">get the total scores for evaluations</param>
        /// <param name="maximum">maximum</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> GetEvaluationsQueryAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string conversationId = null, string agentUserId = null, string evaluatorUserId = null, string queueId = null, string startTime = null, string endTime = null, List<string> evaluationState = null, bool? isReleased = null, bool? agentHasRead = null, bool? expandAnswerTotalScores = null, int? maximum = null)
        {
            
    
            var path_ = "/api/v1/quality/evaluations/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (conversationId != null) queryParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // query parameter
            if (agentUserId != null) queryParams.Add("agentUserId", Configuration.ApiClient.ParameterToString(agentUserId)); // query parameter
            if (evaluatorUserId != null) queryParams.Add("evaluatorUserId", Configuration.ApiClient.ParameterToString(evaluatorUserId)); // query parameter
            if (queueId != null) queryParams.Add("queueId", Configuration.ApiClient.ParameterToString(queueId)); // query parameter
            if (startTime != null) queryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (evaluationState != null) queryParams.Add("evaluationState", Configuration.ApiClient.ParameterToString(evaluationState)); // query parameter
            if (isReleased != null) queryParams.Add("isReleased", Configuration.ApiClient.ParameterToString(isReleased)); // query parameter
            if (agentHasRead != null) queryParams.Add("agentHasRead", Configuration.ApiClient.ParameterToString(agentHasRead)); // query parameter
            if (expandAnswerTotalScores != null) queryParams.Add("expandAnswerTotalScores", Configuration.ApiClient.ParameterToString(expandAnswerTotalScores)); // query parameter
            if (maximum != null) queryParams.Add("maximum", Configuration.ApiClient.ParameterToString(maximum)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetEvaluationsQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEvaluationsQuery: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EvaluationEntityListing)));
            
        }
        
        /// <summary>
        /// Query evaluations 
        /// </summary>
        /// <param name="body">query</param> 
        /// <param name="expand">evaluator,agent</param> 
        /// <returns>EvaluationEntityListing</returns>
        public EvaluationEntityListing CreateEvaluationsQuery (EvaluationQueryRequest body = null, string expand = null)
        {
             ApiResponse<EvaluationEntityListing> response = CreateEvaluationsQueryWithHttpInfo(body, expand);
             return response.Data;
        }

        /// <summary>
        /// Query evaluations 
        /// </summary>
        /// <param name="body">query</param> 
        /// <param name="expand">evaluator,agent</param> 
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        public ApiResponse< EvaluationEntityListing > CreateEvaluationsQueryWithHttpInfo (EvaluationQueryRequest body = null, string expand = null)
        {
            
    
            var path_ = "/api/v1/quality/evaluations/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateEvaluationsQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEvaluationsQuery: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EvaluationEntityListing)));
            
        }
    
        /// <summary>
        /// Query evaluations 
        /// </summary>
        /// <param name="body">query</param>
        /// <param name="expand">evaluator,agent</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluationEntityListing> CreateEvaluationsQueryAsync (EvaluationQueryRequest body = null, string expand = null)
        {
             ApiResponse<EvaluationEntityListing> response = await CreateEvaluationsQueryAsyncWithHttpInfo(body, expand);
             return response.Data;

        }

        /// <summary>
        /// Query evaluations 
        /// </summary>
        /// <param name="body">query</param>
        /// <param name="expand">evaluator,agent</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> CreateEvaluationsQueryAsyncWithHttpInfo (EvaluationQueryRequest body = null, string expand = null)
        {
            
    
            var path_ = "/api/v1/quality/evaluations/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateEvaluationsQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEvaluationsQuery: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EvaluationEntityListing)));
            
        }
        
        /// <summary>
        /// Score evaluation 
        /// </summary>
        /// <param name="body">evaluationAndScoringSet</param> 
        /// <returns>EvaluationScoringSet</returns>
        public EvaluationScoringSet CreateEvaluationsScoring (EvaluationFormAndScoringSet body = null)
        {
             ApiResponse<EvaluationScoringSet> response = CreateEvaluationsScoringWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Score evaluation 
        /// </summary>
        /// <param name="body">evaluationAndScoringSet</param> 
        /// <returns>ApiResponse of EvaluationScoringSet</returns>
        public ApiResponse< EvaluationScoringSet > CreateEvaluationsScoringWithHttpInfo (EvaluationFormAndScoringSet body = null)
        {
            
    
            var path_ = "/api/v1/quality/evaluations/scoring";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateEvaluationsScoring: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEvaluationsScoring: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationScoringSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationScoringSet) Configuration.ApiClient.Deserialize(response, typeof(EvaluationScoringSet)));
            
        }
    
        /// <summary>
        /// Score evaluation 
        /// </summary>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>Task of EvaluationScoringSet</returns>
        public async System.Threading.Tasks.Task<EvaluationScoringSet> CreateEvaluationsScoringAsync (EvaluationFormAndScoringSet body = null)
        {
             ApiResponse<EvaluationScoringSet> response = await CreateEvaluationsScoringAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Score evaluation 
        /// </summary>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>Task of ApiResponse (EvaluationScoringSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationScoringSet>> CreateEvaluationsScoringAsyncWithHttpInfo (EvaluationFormAndScoringSet body = null)
        {
            
    
            var path_ = "/api/v1/quality/evaluations/scoring";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling CreateEvaluationsScoring: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling CreateEvaluationsScoring: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationScoringSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationScoringSet) Configuration.ApiClient.Deserialize(response, typeof(EvaluationScoringSet)));
            
        }
        
        /// <summary>
        /// Get an evaluator activity 
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="name">Evaluator name</param> 
        /// <param name="permission">permission strings</param> 
        /// <param name="group">group id</param> 
        /// <returns>EvaluatorActivityEntityListing</returns>
        public EvaluatorActivityEntityListing GetEvaluatorsActivity (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)
        {
             ApiResponse<EvaluatorActivityEntityListing> response = GetEvaluatorsActivityWithHttpInfo(pageSize, pageNumber, sortBy, expand, startTime, endTime, name, permission, group);
             return response.Data;
        }

        /// <summary>
        /// Get an evaluator activity 
        /// </summary>
        /// <param name="pageSize">The total page size requested</param> 
        /// <param name="pageNumber">The page number requested</param> 
        /// <param name="sortBy">variable name requested to sort by</param> 
        /// <param name="expand">variable name requested by expand list</param> 
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param> 
        /// <param name="name">Evaluator name</param> 
        /// <param name="permission">permission strings</param> 
        /// <param name="group">group id</param> 
        /// <returns>ApiResponse of EvaluatorActivityEntityListing</returns>
        public ApiResponse< EvaluatorActivityEntityListing > GetEvaluatorsActivityWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)
        {
            
    
            var path_ = "/api/v1/quality/evaluators/activity";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (startTime != null) queryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (permission != null) queryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            if (group != null) queryParams.Add("group", Configuration.ApiClient.ParameterToString(group)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetEvaluatorsActivity: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEvaluatorsActivity: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluatorActivityEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluatorActivityEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EvaluatorActivityEntityListing)));
            
        }
    
        /// <summary>
        /// Get an evaluator activity 
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="name">Evaluator name</param>
        /// <param name="permission">permission strings</param>
        /// <param name="group">group id</param>
        /// <returns>Task of EvaluatorActivityEntityListing</returns>
        public async System.Threading.Tasks.Task<EvaluatorActivityEntityListing> GetEvaluatorsActivityAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)
        {
             ApiResponse<EvaluatorActivityEntityListing> response = await GetEvaluatorsActivityAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, startTime, endTime, name, permission, group);
             return response.Data;

        }

        /// <summary>
        /// Get an evaluator activity 
        /// </summary>
        /// <param name="pageSize">The total page size requested</param>
        /// <param name="pageNumber">The page number requested</param>
        /// <param name="sortBy">variable name requested to sort by</param>
        /// <param name="expand">variable name requested by expand list</param>
        /// <param name="startTime">The start time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="endTime">The end time specified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</param>
        /// <param name="name">Evaluator name</param>
        /// <param name="permission">permission strings</param>
        /// <param name="group">group id</param>
        /// <returns>Task of ApiResponse (EvaluatorActivityEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluatorActivityEntityListing>> GetEvaluatorsActivityAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, DateTime? startTime = null, DateTime? endTime = null, string name = null, List<string> permission = null, string group = null)
        {
            
    
            var path_ = "/api/v1/quality/evaluators/activity";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // to determine the Accept header
            String[] http_header_accepts = new String[] {
                "application/json"
            };
            String http_header_accept = Configuration.ApiClient.SelectHeaderAccept(http_header_accepts);
            if (http_header_accept != null)
                headerParams.Add("Accept", Configuration.ApiClient.SelectHeaderAccept(http_header_accepts));

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (pageSize != null) queryParams.Add("pageSize", Configuration.ApiClient.ParameterToString(pageSize)); // query parameter
            if (pageNumber != null) queryParams.Add("pageNumber", Configuration.ApiClient.ParameterToString(pageNumber)); // query parameter
            if (sortBy != null) queryParams.Add("sortBy", Configuration.ApiClient.ParameterToString(sortBy)); // query parameter
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            if (startTime != null) queryParams.Add("startTime", Configuration.ApiClient.ParameterToString(startTime)); // query parameter
            if (endTime != null) queryParams.Add("endTime", Configuration.ApiClient.ParameterToString(endTime)); // query parameter
            if (name != null) queryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (permission != null) queryParams.Add("permission", Configuration.ApiClient.ParameterToString(permission)); // query parameter
            if (group != null) queryParams.Add("group", Configuration.ApiClient.ParameterToString(group)); // query parameter
            
            
            
            

            
            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetEvaluatorsActivity: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetEvaluatorsActivity: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluatorActivityEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluatorActivityEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EvaluatorActivityEntityListing)));
            
        }
        
    }
    
}
