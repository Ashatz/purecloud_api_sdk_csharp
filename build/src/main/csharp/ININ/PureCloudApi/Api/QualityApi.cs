using System;
using System.IO;
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
        List<Recording> GetConversationIdRecordings (string conversationId, int? maxWaitMs = null, string formatId = null);
  
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
        ApiResponse<List<Recording>> GetConversationIdRecordingsWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null);

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
        System.Threading.Tasks.Task<List<Recording>> GetConversationIdRecordingsAsync (string conversationId, int? maxWaitMs = null, string formatId = null);

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
        System.Threading.Tasks.Task<ApiResponse<List<Recording>>> GetConversationIdRecordingsAsyncWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null);
        
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
        void GetConversationIdRecordingsRecordingId (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null);
  
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
        ApiResponse<Object> GetConversationIdRecordingsRecordingIdWithHttpInfo (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null);

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
        System.Threading.Tasks.Task GetConversationIdRecordingsRecordingIdAsync (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> GetConversationIdRecordingsRecordingIdAsyncWithHttpInfo (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null);
        
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
        void PutConversationIdRecordingsRecordingId (string conversationId, string recordingId, Recording body, int? restoreDays = null);
  
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
        ApiResponse<Object> PutConversationIdRecordingsRecordingIdWithHttpInfo (string conversationId, string recordingId, Recording body, int? restoreDays = null);

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
        System.Threading.Tasks.Task PutConversationIdRecordingsRecordingIdAsync (string conversationId, string recordingId, Recording body, int? restoreDays = null);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> PutConversationIdRecordingsRecordingIdAsyncWithHttpInfo (string conversationId, string recordingId, Recording body, int? restoreDays = null);
        
        /// <summary>
        /// Get annotations for recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>List&lt;Annotation&gt;</returns>
        List<Annotation> GetConversationIdRecordingsRecordingIdAnnotations (string conversationId, string recordingId);
  
        /// <summary>
        /// Get annotations for recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>ApiResponse of List&lt;Annotation&gt;</returns>
        ApiResponse<List<Annotation>> GetConversationIdRecordingsRecordingIdAnnotationsWithHttpInfo (string conversationId, string recordingId);

        /// <summary>
        /// Get annotations for recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of List&lt;Annotation&gt;</returns>
        System.Threading.Tasks.Task<List<Annotation>> GetConversationIdRecordingsRecordingIdAnnotationsAsync (string conversationId, string recordingId);

        /// <summary>
        /// Get annotations for recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of ApiResponse (List&lt;Annotation&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Annotation>>> GetConversationIdRecordingsRecordingIdAnnotationsAsyncWithHttpInfo (string conversationId, string recordingId);
        
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
        Annotation PostConversationIdRecordingsRecordingIdAnnotations (string conversationId, string recordingId, Annotation body = null);
  
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
        ApiResponse<Annotation> PostConversationIdRecordingsRecordingIdAnnotationsWithHttpInfo (string conversationId, string recordingId, Annotation body = null);

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
        System.Threading.Tasks.Task<Annotation> PostConversationIdRecordingsRecordingIdAnnotationsAsync (string conversationId, string recordingId, Annotation body = null);

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
        System.Threading.Tasks.Task<ApiResponse<Annotation>> PostConversationIdRecordingsRecordingIdAnnotationsAsyncWithHttpInfo (string conversationId, string recordingId, Annotation body = null);
        
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
        Annotation GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId (string conversationId, string recordingId, string annotationId);
  
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
        ApiResponse<Annotation> GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId);

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
        System.Threading.Tasks.Task<Annotation> GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsync (string conversationId, string recordingId, string annotationId);

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
        System.Threading.Tasks.Task<ApiResponse<Annotation>> GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId);
        
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
        Annotation PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId (string conversationId, string recordingId, string annotationId, Annotation body = null);
  
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
        ApiResponse<Annotation> PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body = null);

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
        System.Threading.Tasks.Task<Annotation> PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsync (string conversationId, string recordingId, string annotationId, Annotation body = null);

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
        System.Threading.Tasks.Task<ApiResponse<Annotation>> PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body = null);
        
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
        void DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId (string conversationId, string recordingId, string annotationId);
  
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
        ApiResponse<Object> DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId);

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
        System.Threading.Tasks.Task DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsync (string conversationId, string recordingId, string annotationId);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId);
        
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
        Calibration PostCalibrations (Calibration body = null, string expand = null);
  
        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> PostCalibrationsWithHttpInfo (Calibration body = null, string expand = null);

        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> PostCalibrationsAsync (Calibration body = null, string expand = null);

        /// <summary>
        /// Create a calibration
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> PostCalibrationsAsyncWithHttpInfo (Calibration body = null, string expand = null);
        
        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Calibration</returns>
        Calibration GetCalibrationsCalibrationId (string calibrationId, string calibratorId = null);
  
        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> GetCalibrationsCalibrationIdWithHttpInfo (string calibrationId, string calibratorId = null);

        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> GetCalibrationsCalibrationIdAsync (string calibrationId, string calibratorId = null);

        /// <summary>
        /// Get a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> GetCalibrationsCalibrationIdAsyncWithHttpInfo (string calibrationId, string calibratorId = null);
        
        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>Calibration</returns>
        Calibration PutCalibrationsCalibrationId (string calibrationId, Calibration body = null);
  
        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> PutCalibrationsCalibrationIdWithHttpInfo (string calibrationId, Calibration body = null);

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> PutCalibrationsCalibrationIdAsync (string calibrationId, Calibration body = null);

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> PutCalibrationsCalibrationIdAsyncWithHttpInfo (string calibrationId, Calibration body = null);
        
        /// <summary>
        /// Delete a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Calibration</returns>
        Calibration DeleteCalibrationsCalibrationId (string calibrationId, string calibratorId = null);
  
        /// <summary>
        /// Delete a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>ApiResponse of Calibration</returns>
        ApiResponse<Calibration> DeleteCalibrationsCalibrationIdWithHttpInfo (string calibrationId, string calibratorId = null);

        /// <summary>
        /// Delete a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of Calibration</returns>
        System.Threading.Tasks.Task<Calibration> DeleteCalibrationsCalibrationIdAsync (string calibrationId, string calibratorId = null);

        /// <summary>
        /// Delete a calibration by id.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        System.Threading.Tasks.Task<ApiResponse<Calibration>> DeleteCalibrationsCalibrationIdAsyncWithHttpInfo (string calibrationId, string calibratorId = null);
        
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
        QualityAuditPage GetConversationsConversationIdAudits (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null);
  
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
        ApiResponse<QualityAuditPage> GetConversationsConversationIdAuditsWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null);

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
        System.Threading.Tasks.Task<QualityAuditPage> GetConversationsConversationIdAuditsAsync (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null);

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
        System.Threading.Tasks.Task<ApiResponse<QualityAuditPage>> GetConversationsConversationIdAuditsAsyncWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null);
        
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
        Evaluation PostConversationsConversationIdEvaluations (string conversationId, Evaluation body = null, string expand = null);
  
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
        ApiResponse<Evaluation> PostConversationsConversationIdEvaluationsWithHttpInfo (string conversationId, Evaluation body = null, string expand = null);

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
        System.Threading.Tasks.Task<Evaluation> PostConversationsConversationIdEvaluationsAsync (string conversationId, Evaluation body = null, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> PostConversationsConversationIdEvaluationsAsyncWithHttpInfo (string conversationId, Evaluation body = null, string expand = null);
        
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
        Evaluation GetConversationsConversationIdEvaluationsEvaluationId (string conversationId, string evaluationId, string expand = null);
  
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
        ApiResponse<Evaluation> GetConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo (string conversationId, string evaluationId, string expand = null);

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
        System.Threading.Tasks.Task<Evaluation> GetConversationsConversationIdEvaluationsEvaluationIdAsync (string conversationId, string evaluationId, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> GetConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null);
        
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
        Evaluation PutConversationsConversationIdEvaluationsEvaluationId (string conversationId, string evaluationId, Evaluation body = null, string expand = null);
  
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
        ApiResponse<Evaluation> PutConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null);

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
        System.Threading.Tasks.Task<Evaluation> PutConversationsConversationIdEvaluationsEvaluationIdAsync (string conversationId, string evaluationId, Evaluation body = null, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> PutConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null);
        
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
        Evaluation DeleteConversationsConversationIdEvaluationsEvaluationId (string conversationId, string evaluationId, string expand = null);
  
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
        ApiResponse<Evaluation> DeleteConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo (string conversationId, string evaluationId, string expand = null);

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
        System.Threading.Tasks.Task<Evaluation> DeleteConversationsConversationIdEvaluationsEvaluationIdAsync (string conversationId, string evaluationId, string expand = null);

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
        System.Threading.Tasks.Task<ApiResponse<Evaluation>> DeleteConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null);
        
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
        EvaluationEntityListing PostEvaluationsQuery (EvaluationQueryRequest body = null, string expand = null);
  
        /// <summary>
        /// Query evaluations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">query</param>
        /// <param name="expand">evaluator,agent</param>
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        ApiResponse<EvaluationEntityListing> PostEvaluationsQueryWithHttpInfo (EvaluationQueryRequest body = null, string expand = null);

        /// <summary>
        /// Query evaluations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">query</param>
        /// <param name="expand">evaluator,agent</param>
        /// <returns>Task of EvaluationEntityListing</returns>
        System.Threading.Tasks.Task<EvaluationEntityListing> PostEvaluationsQueryAsync (EvaluationQueryRequest body = null, string expand = null);

        /// <summary>
        /// Query evaluations
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">query</param>
        /// <param name="expand">evaluator,agent</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> PostEvaluationsQueryAsyncWithHttpInfo (EvaluationQueryRequest body = null, string expand = null);
        
        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>EvaluationScoringSet</returns>
        EvaluationScoringSet PostEvaluationsScoring (EvaluationFormAndScoringSet body = null);
  
        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>ApiResponse of EvaluationScoringSet</returns>
        ApiResponse<EvaluationScoringSet> PostEvaluationsScoringWithHttpInfo (EvaluationFormAndScoringSet body = null);

        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>Task of EvaluationScoringSet</returns>
        System.Threading.Tasks.Task<EvaluationScoringSet> PostEvaluationsScoringAsync (EvaluationFormAndScoringSet body = null);

        /// <summary>
        /// Score evaluation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>Task of ApiResponse (EvaluationScoringSet)</returns>
        System.Threading.Tasks.Task<ApiResponse<EvaluationScoringSet>> PostEvaluationsScoringAsyncWithHttpInfo (EvaluationFormAndScoringSet body = null);
        
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
        public List<Recording> GetConversationIdRecordings (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
             ApiResponse<List<Recording>> response = GetConversationIdRecordingsWithHttpInfo(conversationId, maxWaitMs, formatId);
             return response.Data;
        }

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready.</param> 
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param> 
        /// <returns>ApiResponse of List&lt;Recording&gt;</returns>
        public ApiResponse< List<Recording> > GetConversationIdRecordingsWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->GetConversationIdRecordings");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdRecordings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdRecordings: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<List<Recording>> GetConversationIdRecordingsAsync (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
             ApiResponse<List<Recording>> response = await GetConversationIdRecordingsAsyncWithHttpInfo(conversationId, maxWaitMs, formatId);
             return response.Data;

        }

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings. 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready.</param>
        /// <param name="formatId">The desired format (WEBM, WAV, etc.)</param>
        /// <returns>Task of ApiResponse (List&lt;Recording&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Recording>>> GetConversationIdRecordingsAsyncWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationIdRecordings");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdRecordings: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdRecordings: " + response.ErrorMessage, response.ErrorMessage);

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
        public void GetConversationIdRecordingsRecordingId (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null)
        {
             GetConversationIdRecordingsRecordingIdWithHttpInfo(conversationId, recordingId, maxWaitMs, formatId, download, fileName);
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
        public ApiResponse<Object> GetConversationIdRecordingsRecordingIdWithHttpInfo (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->GetConversationIdRecordingsRecordingId");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->GetConversationIdRecordingsRecordingId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdRecordingsRecordingId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdRecordingsRecordingId: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task GetConversationIdRecordingsRecordingIdAsync (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null)
        {
             await GetConversationIdRecordingsRecordingIdAsyncWithHttpInfo(conversationId, recordingId, maxWaitMs, formatId, download, fileName);

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
        public async System.Threading.Tasks.Task<ApiResponse<Object>> GetConversationIdRecordingsRecordingIdAsyncWithHttpInfo (string conversationId, string recordingId, int? maxWaitMs = null, string formatId = null, bool? download = null, string fileName = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationIdRecordingsRecordingId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling GetConversationIdRecordingsRecordingId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdRecordingsRecordingId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdRecordingsRecordingId: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public void PutConversationIdRecordingsRecordingId (string conversationId, string recordingId, Recording body, int? restoreDays = null)
        {
             PutConversationIdRecordingsRecordingIdWithHttpInfo(conversationId, recordingId, body, restoreDays);
        }

        /// <summary>
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays=10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <param name="body">recording</param> 
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated.</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PutConversationIdRecordingsRecordingIdWithHttpInfo (string conversationId, string recordingId, Recording body, int? restoreDays = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->PutConversationIdRecordingsRecordingId");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->PutConversationIdRecordingsRecordingId");
            
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling QualityApi->PutConversationIdRecordingsRecordingId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            if (restoreDays != null) queryParams.Add("restoreDays", Configuration.ApiClient.ParameterToString(restoreDays)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutConversationIdRecordingsRecordingId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutConversationIdRecordingsRecordingId: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task PutConversationIdRecordingsRecordingIdAsync (string conversationId, string recordingId, Recording body, int? restoreDays = null)
        {
             await PutConversationIdRecordingsRecordingIdAsyncWithHttpInfo(conversationId, recordingId, body, restoreDays);

        }

        /// <summary>
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. Use of the query parameter &#39;restoreDays&#39; is deprecated and will be removed in the next major version release. If &#39;restoreDays&#39; is provided, no attempt at updating other retention data will be made. To migrate to the new usage, issuing a request with restoreDays=10 would instead set the archiveDate&#39;s time stamp in the PUT body to 10 days in the future.
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <param name="restoreDays">The number of days the recording will be available before it is re-archived. Deprecated.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PutConversationIdRecordingsRecordingIdAsyncWithHttpInfo (string conversationId, string recordingId, Recording body, int? restoreDays = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PutConversationIdRecordingsRecordingId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling PutConversationIdRecordingsRecordingId");
            // verify the required parameter 'body' is set
            if (body == null) throw new ApiException(400, "Missing required parameter 'body' when calling PutConversationIdRecordingsRecordingId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutConversationIdRecordingsRecordingId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutConversationIdRecordingsRecordingId: " + response.ErrorMessage, response.ErrorMessage);

            
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
        public List<Annotation> GetConversationIdRecordingsRecordingIdAnnotations (string conversationId, string recordingId)
        {
             ApiResponse<List<Annotation>> response = GetConversationIdRecordingsRecordingIdAnnotationsWithHttpInfo(conversationId, recordingId);
             return response.Data;
        }

        /// <summary>
        /// Get annotations for recording 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <returns>ApiResponse of List&lt;Annotation&gt;</returns>
        public ApiResponse< List<Annotation> > GetConversationIdRecordingsRecordingIdAnnotationsWithHttpInfo (string conversationId, string recordingId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->GetConversationIdRecordingsRecordingIdAnnotations");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->GetConversationIdRecordingsRecordingIdAnnotations");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdRecordingsRecordingIdAnnotations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdRecordingsRecordingIdAnnotations: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<List<Annotation>> GetConversationIdRecordingsRecordingIdAnnotationsAsync (string conversationId, string recordingId)
        {
             ApiResponse<List<Annotation>> response = await GetConversationIdRecordingsRecordingIdAnnotationsAsyncWithHttpInfo(conversationId, recordingId);
             return response.Data;

        }

        /// <summary>
        /// Get annotations for recording 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of ApiResponse (List&lt;Annotation&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Annotation>>> GetConversationIdRecordingsRecordingIdAnnotationsAsyncWithHttpInfo (string conversationId, string recordingId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationIdRecordingsRecordingIdAnnotations");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling GetConversationIdRecordingsRecordingIdAnnotations");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdRecordingsRecordingIdAnnotations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdRecordingsRecordingIdAnnotations: " + response.ErrorMessage, response.ErrorMessage);

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
        public Annotation PostConversationIdRecordingsRecordingIdAnnotations (string conversationId, string recordingId, Annotation body = null)
        {
             ApiResponse<Annotation> response = PostConversationIdRecordingsRecordingIdAnnotationsWithHttpInfo(conversationId, recordingId, body);
             return response.Data;
        }

        /// <summary>
        /// Create annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <param name="body">annotation</param> 
        /// <returns>ApiResponse of Annotation</returns>
        public ApiResponse< Annotation > PostConversationIdRecordingsRecordingIdAnnotationsWithHttpInfo (string conversationId, string recordingId, Annotation body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->PostConversationIdRecordingsRecordingIdAnnotations");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->PostConversationIdRecordingsRecordingIdAnnotations");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationIdRecordingsRecordingIdAnnotations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationIdRecordingsRecordingIdAnnotations: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Annotation> PostConversationIdRecordingsRecordingIdAnnotationsAsync (string conversationId, string recordingId, Annotation body = null)
        {
             ApiResponse<Annotation> response = await PostConversationIdRecordingsRecordingIdAnnotationsAsyncWithHttpInfo(conversationId, recordingId, body);
             return response.Data;

        }

        /// <summary>
        /// Create annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Annotation>> PostConversationIdRecordingsRecordingIdAnnotationsAsyncWithHttpInfo (string conversationId, string recordingId, Annotation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PostConversationIdRecordingsRecordingIdAnnotations");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling PostConversationIdRecordingsRecordingIdAnnotations");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationIdRecordingsRecordingIdAnnotations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationIdRecordingsRecordingIdAnnotations: " + response.ErrorMessage, response.ErrorMessage);

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
        public Annotation GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId (string conversationId, string recordingId, string annotationId)
        {
             ApiResponse<Annotation> response = GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo(conversationId, recordingId, annotationId);
             return response.Data;
        }

        /// <summary>
        /// Get annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <param name="annotationId">Annotation ID</param> 
        /// <returns>ApiResponse of Annotation</returns>
        public ApiResponse< Annotation > GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling QualityApi->GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Annotation> GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsync (string conversationId, string recordingId, string annotationId)
        {
             ApiResponse<Annotation> response = await GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo(conversationId, recordingId, annotationId);
             return response.Data;

        }

        /// <summary>
        /// Get annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Annotation>> GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null) throw new ApiException(400, "Missing required parameter 'annotationId' when calling GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Annotation PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId (string conversationId, string recordingId, string annotationId, Annotation body = null)
        {
             ApiResponse<Annotation> response = PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo(conversationId, recordingId, annotationId, body);
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
        public ApiResponse< Annotation > PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling QualityApi->PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (recordingId != null) pathParams.Add("recordingId", Configuration.ApiClient.ParameterToString(recordingId)); // path parameter
            if (annotationId != null) pathParams.Add("annotationId", Configuration.ApiClient.ParameterToString(annotationId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Annotation> PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsync (string conversationId, string recordingId, string annotationId, Annotation body = null)
        {
             ApiResponse<Annotation> response = await PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo(conversationId, recordingId, annotationId, body);
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
        public async System.Threading.Tasks.Task<ApiResponse<Annotation>> PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null) throw new ApiException(400, "Missing required parameter 'annotationId' when calling PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + response.ErrorMessage, response.ErrorMessage);

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
        public void DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId (string conversationId, string recordingId, string annotationId)
        {
             DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo(conversationId, recordingId, annotationId);
        }

        /// <summary>
        /// Delete annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param> 
        /// <param name="recordingId">Recording ID</param> 
        /// <param name="annotationId">Annotation ID</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling QualityApi->DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling QualityApi->DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + response.ErrorMessage, response.ErrorMessage);
    
            
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
        public async System.Threading.Tasks.Task DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsync (string conversationId, string recordingId, string annotationId)
        {
             await DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo(conversationId, recordingId, annotationId);

        }

        /// <summary>
        /// Delete annotation 
        /// </summary>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null) throw new ApiException(400, "Missing required parameter 'recordingId' when calling DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null) throw new ApiException(400, "Missing required parameter 'annotationId' when calling DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            
    
            var path_ = "/api/v1/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + response.ErrorMessage, response.ErrorMessage);

            
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
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

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
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

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
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

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
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

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
        public Calibration PostCalibrations (Calibration body = null, string expand = null)
        {
             ApiResponse<Calibration> response = PostCalibrationsWithHttpInfo(body, expand);
             return response.Data;
        }

        /// <summary>
        /// Create a calibration 
        /// </summary>
        /// <param name="body">calibration</param> 
        /// <param name="expand">calibratorId</param> 
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > PostCalibrationsWithHttpInfo (Calibration body = null, string expand = null)
        {
            
    
            var path_ = "/api/v1/quality/calibrations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostCalibrations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostCalibrations: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Calibration> PostCalibrationsAsync (Calibration body = null, string expand = null)
        {
             ApiResponse<Calibration> response = await PostCalibrationsAsyncWithHttpInfo(body, expand);
             return response.Data;

        }

        /// <summary>
        /// Create a calibration 
        /// </summary>
        /// <param name="body">calibration</param>
        /// <param name="expand">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> PostCalibrationsAsyncWithHttpInfo (Calibration body = null, string expand = null)
        {
            
    
            var path_ = "/api/v1/quality/calibrations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostCalibrations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostCalibrations: " + response.ErrorMessage, response.ErrorMessage);

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
        public Calibration GetCalibrationsCalibrationId (string calibrationId, string calibratorId = null)
        {
             ApiResponse<Calibration> response = GetCalibrationsCalibrationIdWithHttpInfo(calibrationId, calibratorId);
             return response.Data;
        }

        /// <summary>
        /// Get a calibration by id. 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param> 
        /// <param name="calibratorId">calibratorId</param> 
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > GetCalibrationsCalibrationIdWithHttpInfo (string calibrationId, string calibratorId = null)
        {
            
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->GetCalibrationsCalibrationId");
            
    
            var path_ = "/api/v1/quality/calibrations/{calibrationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCalibrationsCalibrationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCalibrationsCalibrationId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Calibration> GetCalibrationsCalibrationIdAsync (string calibrationId, string calibratorId = null)
        {
             ApiResponse<Calibration> response = await GetCalibrationsCalibrationIdAsyncWithHttpInfo(calibrationId, calibratorId);
             return response.Data;

        }

        /// <summary>
        /// Get a calibration by id. 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> GetCalibrationsCalibrationIdAsyncWithHttpInfo (string calibrationId, string calibratorId = null)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null) throw new ApiException(400, "Missing required parameter 'calibrationId' when calling GetCalibrationsCalibrationId");
            
    
            var path_ = "/api/v1/quality/calibrations/{calibrationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetCalibrationsCalibrationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetCalibrationsCalibrationId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Calibration PutCalibrationsCalibrationId (string calibrationId, Calibration body = null)
        {
             ApiResponse<Calibration> response = PutCalibrationsCalibrationIdWithHttpInfo(calibrationId, body);
             return response.Data;
        }

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param> 
        /// <param name="body">Calibration</param> 
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > PutCalibrationsCalibrationIdWithHttpInfo (string calibrationId, Calibration body = null)
        {
            
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->PutCalibrationsCalibrationId");
            
    
            var path_ = "/api/v1/quality/calibrations/{calibrationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (calibrationId != null) pathParams.Add("calibrationId", Configuration.ApiClient.ParameterToString(calibrationId)); // path parameter
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutCalibrationsCalibrationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutCalibrationsCalibrationId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Calibration> PutCalibrationsCalibrationIdAsync (string calibrationId, Calibration body = null)
        {
             ApiResponse<Calibration> response = await PutCalibrationsCalibrationIdAsyncWithHttpInfo(calibrationId, body);
             return response.Data;

        }

        /// <summary>
        /// Update a calibration to the specified calibration via PUT.  Editable fields include: evaluators, expertEvaluator, and scoringIndex 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="body">Calibration</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> PutCalibrationsCalibrationIdAsyncWithHttpInfo (string calibrationId, Calibration body = null)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null) throw new ApiException(400, "Missing required parameter 'calibrationId' when calling PutCalibrationsCalibrationId");
            
    
            var path_ = "/api/v1/quality/calibrations/{calibrationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutCalibrationsCalibrationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutCalibrationsCalibrationId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Calibration DeleteCalibrationsCalibrationId (string calibrationId, string calibratorId = null)
        {
             ApiResponse<Calibration> response = DeleteCalibrationsCalibrationIdWithHttpInfo(calibrationId, calibratorId);
             return response.Data;
        }

        /// <summary>
        /// Delete a calibration by id. 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param> 
        /// <param name="calibratorId">calibratorId</param> 
        /// <returns>ApiResponse of Calibration</returns>
        public ApiResponse< Calibration > DeleteCalibrationsCalibrationIdWithHttpInfo (string calibrationId, string calibratorId = null)
        {
            
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null)
                throw new ApiException(400, "Missing required parameter 'calibrationId' when calling QualityApi->DeleteCalibrationsCalibrationId");
            
    
            var path_ = "/api/v1/quality/calibrations/{calibrationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteCalibrationsCalibrationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteCalibrationsCalibrationId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Calibration> DeleteCalibrationsCalibrationIdAsync (string calibrationId, string calibratorId = null)
        {
             ApiResponse<Calibration> response = await DeleteCalibrationsCalibrationIdAsyncWithHttpInfo(calibrationId, calibratorId);
             return response.Data;

        }

        /// <summary>
        /// Delete a calibration by id. 
        /// </summary>
        /// <param name="calibrationId">Calibration ID</param>
        /// <param name="calibratorId">calibratorId</param>
        /// <returns>Task of ApiResponse (Calibration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Calibration>> DeleteCalibrationsCalibrationIdAsyncWithHttpInfo (string calibrationId, string calibratorId = null)
        {
            // verify the required parameter 'calibrationId' is set
            if (calibrationId == null) throw new ApiException(400, "Missing required parameter 'calibrationId' when calling DeleteCalibrationsCalibrationId");
            
    
            var path_ = "/api/v1/quality/calibrations/{calibrationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteCalibrationsCalibrationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteCalibrationsCalibrationId: " + response.ErrorMessage, response.ErrorMessage);

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
        public QualityAuditPage GetConversationsConversationIdAudits (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)
        {
             ApiResponse<QualityAuditPage> response = GetConversationsConversationIdAuditsWithHttpInfo(conversationId, pageSize, pageNumber, sortBy, expand, recordingId, entityType);
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
        public ApiResponse< QualityAuditPage > GetConversationsConversationIdAuditsWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->GetConversationsConversationIdAudits");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/audits";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationsConversationIdAudits: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationsConversationIdAudits: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<QualityAuditPage> GetConversationsConversationIdAuditsAsync (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)
        {
             ApiResponse<QualityAuditPage> response = await GetConversationsConversationIdAuditsAsyncWithHttpInfo(conversationId, pageSize, pageNumber, sortBy, expand, recordingId, entityType);
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
        public async System.Threading.Tasks.Task<ApiResponse<QualityAuditPage>> GetConversationsConversationIdAuditsAsyncWithHttpInfo (string conversationId, int? pageSize = null, int? pageNumber = null, string sortBy = null, List<string> expand = null, string recordingId = null, string entityType = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationsConversationIdAudits");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/audits";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationsConversationIdAudits: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationsConversationIdAudits: " + response.ErrorMessage, response.ErrorMessage);

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
        public Evaluation PostConversationsConversationIdEvaluations (string conversationId, Evaluation body = null, string expand = null)
        {
             ApiResponse<Evaluation> response = PostConversationsConversationIdEvaluationsWithHttpInfo(conversationId, body, expand);
             return response.Data;
        }

        /// <summary>
        /// Create an evaluation 
        /// </summary>
        /// <param name="conversationId"></param> 
        /// <param name="body">evaluation</param> 
        /// <param name="expand">evaluatorId</param> 
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > PostConversationsConversationIdEvaluationsWithHttpInfo (string conversationId, Evaluation body = null, string expand = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->PostConversationsConversationIdEvaluations");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/evaluations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationsConversationIdEvaluations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationsConversationIdEvaluations: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Evaluation> PostConversationsConversationIdEvaluationsAsync (string conversationId, Evaluation body = null, string expand = null)
        {
             ApiResponse<Evaluation> response = await PostConversationsConversationIdEvaluationsAsyncWithHttpInfo(conversationId, body, expand);
             return response.Data;

        }

        /// <summary>
        /// Create an evaluation 
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="body">evaluation</param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> PostConversationsConversationIdEvaluationsAsyncWithHttpInfo (string conversationId, Evaluation body = null, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PostConversationsConversationIdEvaluations");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/evaluations";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostConversationsConversationIdEvaluations: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostConversationsConversationIdEvaluations: " + response.ErrorMessage, response.ErrorMessage);

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
        public Evaluation GetConversationsConversationIdEvaluationsEvaluationId (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> response = GetConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo(conversationId, evaluationId, expand);
             return response.Data;
        }

        /// <summary>
        /// Get an evaluation 
        /// </summary>
        /// <param name="conversationId"></param> 
        /// <param name="evaluationId"></param> 
        /// <param name="expand">agent, evaluator, evaluationForm</param> 
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > GetConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->GetConversationsConversationIdEvaluationsEvaluationId");
            
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->GetConversationsConversationIdEvaluationsEvaluationId");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationsConversationIdEvaluationsEvaluationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationsConversationIdEvaluationsEvaluationId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Evaluation> GetConversationsConversationIdEvaluationsEvaluationIdAsync (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> response = await GetConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo(conversationId, evaluationId, expand);
             return response.Data;

        }

        /// <summary>
        /// Get an evaluation 
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">agent, evaluator, evaluationForm</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> GetConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling GetConversationsConversationIdEvaluationsEvaluationId");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null) throw new ApiException(400, "Missing required parameter 'evaluationId' when calling GetConversationsConversationIdEvaluationsEvaluationId");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetConversationsConversationIdEvaluationsEvaluationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetConversationsConversationIdEvaluationsEvaluationId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Evaluation PutConversationsConversationIdEvaluationsEvaluationId (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
             ApiResponse<Evaluation> response = PutConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo(conversationId, evaluationId, body, expand);
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
        public ApiResponse< Evaluation > PutConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->PutConversationsConversationIdEvaluationsEvaluationId");
            
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->PutConversationsConversationIdEvaluationsEvaluationId");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (conversationId != null) pathParams.Add("conversationId", Configuration.ApiClient.ParameterToString(conversationId)); // path parameter
            if (evaluationId != null) pathParams.Add("evaluationId", Configuration.ApiClient.ParameterToString(evaluationId)); // path parameter
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutConversationsConversationIdEvaluationsEvaluationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutConversationsConversationIdEvaluationsEvaluationId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Evaluation> PutConversationsConversationIdEvaluationsEvaluationIdAsync (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
             ApiResponse<Evaluation> response = await PutConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo(conversationId, evaluationId, body, expand);
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
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> PutConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, Evaluation body = null, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling PutConversationsConversationIdEvaluationsEvaluationId");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null) throw new ApiException(400, "Missing required parameter 'evaluationId' when calling PutConversationsConversationIdEvaluationsEvaluationId");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PUT, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PutConversationsConversationIdEvaluationsEvaluationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PutConversationsConversationIdEvaluationsEvaluationId: " + response.ErrorMessage, response.ErrorMessage);

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
        public Evaluation DeleteConversationsConversationIdEvaluationsEvaluationId (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> response = DeleteConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo(conversationId, evaluationId, expand);
             return response.Data;
        }

        /// <summary>
        /// Delete an evaluation 
        /// </summary>
        /// <param name="conversationId"></param> 
        /// <param name="evaluationId"></param> 
        /// <param name="expand">evaluatorId</param> 
        /// <returns>ApiResponse of Evaluation</returns>
        public ApiResponse< Evaluation > DeleteConversationsConversationIdEvaluationsEvaluationIdWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling QualityApi->DeleteConversationsConversationIdEvaluationsEvaluationId");
            
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null)
                throw new ApiException(400, "Missing required parameter 'evaluationId' when calling QualityApi->DeleteConversationsConversationIdEvaluationsEvaluationId");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteConversationsConversationIdEvaluationsEvaluationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteConversationsConversationIdEvaluationsEvaluationId: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<Evaluation> DeleteConversationsConversationIdEvaluationsEvaluationIdAsync (string conversationId, string evaluationId, string expand = null)
        {
             ApiResponse<Evaluation> response = await DeleteConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo(conversationId, evaluationId, expand);
             return response.Data;

        }

        /// <summary>
        /// Delete an evaluation 
        /// </summary>
        /// <param name="conversationId"></param>
        /// <param name="evaluationId"></param>
        /// <param name="expand">evaluatorId</param>
        /// <returns>Task of ApiResponse (Evaluation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Evaluation>> DeleteConversationsConversationIdEvaluationsEvaluationIdAsyncWithHttpInfo (string conversationId, string evaluationId, string expand = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null) throw new ApiException(400, "Missing required parameter 'conversationId' when calling DeleteConversationsConversationIdEvaluationsEvaluationId");
            // verify the required parameter 'evaluationId' is set
            if (evaluationId == null) throw new ApiException(400, "Missing required parameter 'evaluationId' when calling DeleteConversationsConversationIdEvaluationsEvaluationId");
            
    
            var path_ = "/api/v1/quality/conversations/{conversationId}/evaluations/{evaluationId}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteConversationsConversationIdEvaluationsEvaluationId: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteConversationsConversationIdEvaluationsEvaluationId: " + response.ErrorMessage, response.ErrorMessage);

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
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

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
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

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
        public EvaluationEntityListing PostEvaluationsQuery (EvaluationQueryRequest body = null, string expand = null)
        {
             ApiResponse<EvaluationEntityListing> response = PostEvaluationsQueryWithHttpInfo(body, expand);
             return response.Data;
        }

        /// <summary>
        /// Query evaluations 
        /// </summary>
        /// <param name="body">query</param> 
        /// <param name="expand">evaluator,agent</param> 
        /// <returns>ApiResponse of EvaluationEntityListing</returns>
        public ApiResponse< EvaluationEntityListing > PostEvaluationsQueryWithHttpInfo (EvaluationQueryRequest body = null, string expand = null)
        {
            
    
            var path_ = "/api/v1/quality/evaluations/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (expand != null) queryParams.Add("expand", Configuration.ApiClient.ParameterToString(expand)); // query parameter
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostEvaluationsQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEvaluationsQuery: " + response.ErrorMessage, response.ErrorMessage);
    
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
        public async System.Threading.Tasks.Task<EvaluationEntityListing> PostEvaluationsQueryAsync (EvaluationQueryRequest body = null, string expand = null)
        {
             ApiResponse<EvaluationEntityListing> response = await PostEvaluationsQueryAsyncWithHttpInfo(body, expand);
             return response.Data;

        }

        /// <summary>
        /// Query evaluations 
        /// </summary>
        /// <param name="body">query</param>
        /// <param name="expand">evaluator,agent</param>
        /// <returns>Task of ApiResponse (EvaluationEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationEntityListing>> PostEvaluationsQueryAsyncWithHttpInfo (EvaluationQueryRequest body = null, string expand = null)
        {
            
    
            var path_ = "/api/v1/quality/evaluations/query";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostEvaluationsQuery: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEvaluationsQuery: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<EvaluationEntityListing>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationEntityListing) Configuration.ApiClient.Deserialize(response, typeof(EvaluationEntityListing)));
            
        }
        
        /// <summary>
        /// Score evaluation 
        /// </summary>
        /// <param name="body">evaluationAndScoringSet</param> 
        /// <returns>EvaluationScoringSet</returns>
        public EvaluationScoringSet PostEvaluationsScoring (EvaluationFormAndScoringSet body = null)
        {
             ApiResponse<EvaluationScoringSet> response = PostEvaluationsScoringWithHttpInfo(body);
             return response.Data;
        }

        /// <summary>
        /// Score evaluation 
        /// </summary>
        /// <param name="body">evaluationAndScoringSet</param> 
        /// <returns>ApiResponse of EvaluationScoringSet</returns>
        public ApiResponse< EvaluationScoringSet > PostEvaluationsScoringWithHttpInfo (EvaluationFormAndScoringSet body = null)
        {
            
    
            var path_ = "/api/v1/quality/evaluations/scoring";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (body.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                postBody = body; // byte array
            }

            // authentication (PureCloud Auth) required
            
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostEvaluationsScoring: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEvaluationsScoring: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<EvaluationScoringSet>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EvaluationScoringSet) Configuration.ApiClient.Deserialize(response, typeof(EvaluationScoringSet)));
            
        }
    
        /// <summary>
        /// Score evaluation 
        /// </summary>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>Task of EvaluationScoringSet</returns>
        public async System.Threading.Tasks.Task<EvaluationScoringSet> PostEvaluationsScoringAsync (EvaluationFormAndScoringSet body = null)
        {
             ApiResponse<EvaluationScoringSet> response = await PostEvaluationsScoringAsyncWithHttpInfo(body);
             return response.Data;

        }

        /// <summary>
        /// Score evaluation 
        /// </summary>
        /// <param name="body">evaluationAndScoringSet</param>
        /// <returns>Task of ApiResponse (EvaluationScoringSet)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EvaluationScoringSet>> PostEvaluationsScoringAsyncWithHttpInfo (EvaluationFormAndScoringSet body = null)
        {
            
    
            var path_ = "/api/v1/quality/evaluations/scoring";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling PostEvaluationsScoring: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling PostEvaluationsScoring: " + response.ErrorMessage, response.ErrorMessage);

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
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

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
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                "application/json"
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

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
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

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
