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
    public interface IRecordingApi : IApiAccessor
    {
        #region Synchronous Operations
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
        void DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId (string conversationId, string recordingId, string annotationId);

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
        ApiResponse<Object> DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId);
        /// <summary>
        /// Delete media retention policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>string</returns>
        string DeleteMediaretentionpolicies (string ids);

        /// <summary>
        /// Delete media retention policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteMediaretentionpoliciesWithHttpInfo (string ids);
        /// <summary>
        /// Delete a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>string</returns>
        string DeleteMediaretentionpoliciesPolicyId (string policyId);

        /// <summary>
        /// Delete a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> DeleteMediaretentionpoliciesPolicyIdWithHttpInfo (string policyId);
        /// <summary>
        /// Deletes a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>OrphanRecording</returns>
        OrphanRecording DeleteOrphanId (string orphanId);

        /// <summary>
        /// Deletes a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>ApiResponse of OrphanRecording</returns>
        ApiResponse<OrphanRecording> DeleteOrphanIdWithHttpInfo (string orphanId);
        /// <summary>
        /// Get all of a Conversation&#39;s Recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional, default to 5000)</param>
        /// <param name="formatId">The desired media format (optional, default to WEBM)</param>
        /// <returns>List&lt;Recording&gt;</returns>
        List<Recording> GetConversationIdRecordings (string conversationId, int? maxWaitMs = null, string formatId = null);

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional, default to 5000)</param>
        /// <param name="formatId">The desired media format (optional, default to WEBM)</param>
        /// <returns>ApiResponse of List&lt;Recording&gt;</returns>
        ApiResponse<List<Recording>> GetConversationIdRecordingsWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null);
        /// <summary>
        /// Gets a specific recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>Recording</returns>
        Recording GetConversationIdRecordingsRecordingId (string conversationId, string recordingId, string formatId = null, bool? download = null, string fileName = null);

        /// <summary>
        /// Gets a specific recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>ApiResponse of Recording</returns>
        ApiResponse<Recording> GetConversationIdRecordingsRecordingIdWithHttpInfo (string conversationId, string recordingId, string formatId = null, bool? download = null, string fileName = null);
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
        List<Annotation> GetConversationIdRecordingsRecordingIdAnnotations (string conversationId, string recordingId);

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
        ApiResponse<List<Annotation>> GetConversationIdRecordingsRecordingIdAnnotationsWithHttpInfo (string conversationId, string recordingId);
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
        Annotation GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId (string conversationId, string recordingId, string annotationId);

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
        ApiResponse<Annotation> GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId);
        /// <summary>
        /// gets a list local key settings data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>LocalEncryptionConfigurationListing</returns>
        LocalEncryptionConfigurationListing GetLocalkeysSettings ();

        /// <summary>
        /// gets a list local key settings data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of LocalEncryptionConfigurationListing</returns>
        ApiResponse<LocalEncryptionConfigurationListing> GetLocalkeysSettingsWithHttpInfo ();
        /// <summary>
        /// Get the local encryption settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <returns>LocalEncryptionConfiguration</returns>
        LocalEncryptionConfiguration GetLocalkeysSettingsSettingsId (string settingsId);

        /// <summary>
        /// Get the local encryption settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <returns>ApiResponse of LocalEncryptionConfiguration</returns>
        ApiResponse<LocalEncryptionConfiguration> GetLocalkeysSettingsSettingsIdWithHttpInfo (string settingsId);
        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary&#x3D;true to this endpoint
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <returns>PolicyEntityListing</returns>
        PolicyEntityListing GetMediaretentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary&#x3D;true to this endpoint
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <returns>ApiResponse of PolicyEntityListing</returns>
        ApiResponse<PolicyEntityListing> GetMediaretentionpoliciesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);
        /// <summary>
        /// Get a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Policy</returns>
        Policy GetMediaretentionpoliciesPolicyId (string policyId);

        /// <summary>
        /// Get a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> GetMediaretentionpoliciesPolicyIdWithHttpInfo (string policyId);
        /// <summary>
        /// Gets a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>OrphanRecording</returns>
        OrphanRecording GetOrphanId (string orphanId);

        /// <summary>
        /// Gets a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>ApiResponse of OrphanRecording</returns>
        ApiResponse<OrphanRecording> GetOrphanIdWithHttpInfo (string orphanId);
        /// <summary>
        /// Gets the media of a single orphan recording
        /// </summary>
        /// <remarks>
        /// A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>Recording</returns>
        Recording GetOrphanIdMedia (string orphanId, string formatId = null, bool? download = null, string fileName = null);

        /// <summary>
        /// Gets the media of a single orphan recording
        /// </summary>
        /// <remarks>
        /// A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>ApiResponse of Recording</returns>
        ApiResponse<Recording> GetOrphanIdMediaWithHttpInfo (string orphanId, string formatId = null, bool? download = null, string fileName = null);
        /// <summary>
        /// Gets all orphan recordings
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
        /// <param name="hasConversation">Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional, default to false)</param>
        /// <returns>OrphanRecordingListing</returns>
        OrphanRecordingListing GetOrphanrecordings (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null);

        /// <summary>
        /// Gets all orphan recordings
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
        /// <param name="hasConversation">Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional, default to false)</param>
        /// <returns>ApiResponse of OrphanRecordingListing</returns>
        ApiResponse<OrphanRecordingListing> GetOrphanrecordingsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null);
        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>EncryptionKeyEntityListing</returns>
        EncryptionKeyEntityListing GetRecordingkeys (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of EncryptionKeyEntityListing</returns>
        ApiResponse<EncryptionKeyEntityListing> GetRecordingkeysWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KeyRotationSchedule</returns>
        KeyRotationSchedule GetRecordingkeysRotationschedule ();

        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        ApiResponse<KeyRotationSchedule> GetRecordingkeysRotationscheduleWithHttpInfo ();
        /// <summary>
        /// Get the Recording Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDefault">If no settings are found, a new one is created with default values (optional, default to false)</param>
        /// <returns>RecordingSettings</returns>
        RecordingSettings GetSettings (bool? createDefault = null);

        /// <summary>
        /// Get the Recording Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDefault">If no settings are found, a new one is created with default values (optional, default to false)</param>
        /// <returns>ApiResponse of RecordingSettings</returns>
        ApiResponse<RecordingSettings> GetSettingsWithHttpInfo (bool? createDefault = null);
        /// <summary>
        /// Retrieves a paged listing of screen recording sessions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ScreenRecordingSessionListing</returns>
        ScreenRecordingSessionListing GetsScreensessions (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Retrieves a paged listing of screen recording sessions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of ScreenRecordingSessionListing</returns>
        ApiResponse<ScreenRecordingSessionListing> GetsScreensessionsWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Patch a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PatchMediaretentionpoliciesPolicyId (string policyId, Policy body);

        /// <summary>
        /// Patch a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PatchMediaretentionpoliciesPolicyIdWithHttpInfo (string policyId, Policy body);
        /// <summary>
        /// Update a screen recording session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingSessionId">Screen recording session ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        void PatchsScreensessionsRecordingsessionId (string recordingSessionId, ScreenRecordingSessionRequest body = null);

        /// <summary>
        /// Update a screen recording session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingSessionId">Screen recording session ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> PatchsScreensessionsRecordingsessionIdWithHttpInfo (string recordingSessionId, ScreenRecordingSessionRequest body = null);
        /// <summary>
        /// Create annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Annotation</returns>
        Annotation PostConversationIdRecordingsRecordingIdAnnotations (string conversationId, string recordingId, Annotation body);

        /// <summary>
        /// Create annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>ApiResponse of Annotation</returns>
        ApiResponse<Annotation> PostConversationIdRecordingsRecordingIdAnnotationsWithHttpInfo (string conversationId, string recordingId, Annotation body);
        /// <summary>
        /// create a local recording key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption body</param>
        /// <returns>EncryptionKey</returns>
        EncryptionKey PostLocalkeys (LocalEncryptionKeyRequest body);

        /// <summary>
        /// create a local recording key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption body</param>
        /// <returns>ApiResponse of EncryptionKey</returns>
        ApiResponse<EncryptionKey> PostLocalkeysWithHttpInfo (LocalEncryptionKeyRequest body);
        /// <summary>
        /// create settings for local key creation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption Configuration</param>
        /// <returns>LocalEncryptionConfiguration</returns>
        LocalEncryptionConfiguration PostLocalkeysSettings (LocalEncryptionConfiguration body);

        /// <summary>
        /// create settings for local key creation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption Configuration</param>
        /// <returns>ApiResponse of LocalEncryptionConfiguration</returns>
        ApiResponse<LocalEncryptionConfiguration> PostLocalkeysSettingsWithHttpInfo (LocalEncryptionConfiguration body);
        /// <summary>
        /// Create media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PostMediaretentionpolicies (PolicyCreate body);

        /// <summary>
        /// Create media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PostMediaretentionpoliciesWithHttpInfo (PolicyCreate body);
        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EncryptionKey</returns>
        EncryptionKey PostRecordingkeys ();

        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EncryptionKey</returns>
        ApiResponse<EncryptionKey> PostRecordingkeysWithHttpInfo ();
        /// <summary>
        /// Updates the retention records on a recording.
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <returns>Recording</returns>
        Recording PutConversationIdRecordingsRecordingId (string conversationId, string recordingId, Recording body);

        /// <summary>
        /// Updates the retention records on a recording.
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <returns>ApiResponse of Recording</returns>
        ApiResponse<Recording> PutConversationIdRecordingsRecordingIdWithHttpInfo (string conversationId, string recordingId, Recording body);
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
        /// <param name="body">annotation</param>
        /// <returns>Annotation</returns>
        Annotation PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId (string conversationId, string recordingId, string annotationId, Annotation body);

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
        /// <param name="body">annotation</param>
        /// <returns>ApiResponse of Annotation</returns>
        ApiResponse<Annotation> PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body);
        /// <summary>
        /// Update the local encryption settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <param name="body">Local Encryption metadata</param>
        /// <returns>LocalEncryptionConfiguration</returns>
        LocalEncryptionConfiguration PutLocalkeysSettingsSettingsId (string settingsId, LocalEncryptionConfiguration body);

        /// <summary>
        /// Update the local encryption settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <param name="body">Local Encryption metadata</param>
        /// <returns>ApiResponse of LocalEncryptionConfiguration</returns>
        ApiResponse<LocalEncryptionConfiguration> PutLocalkeysSettingsSettingsIdWithHttpInfo (string settingsId, LocalEncryptionConfiguration body);
        /// <summary>
        /// Update a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        Policy PutMediaretentionpoliciesPolicyId (string policyId, Policy body);

        /// <summary>
        /// Update a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        ApiResponse<Policy> PutMediaretentionpoliciesPolicyIdWithHttpInfo (string policyId, Policy body);
        /// <summary>
        /// Updates an orphan recording to a regular recording with retention values
        /// </summary>
        /// <remarks>
        /// If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Recording</returns>
        Recording PutOrphanId (string orphanId, OrphanUpdateRequest body = null);

        /// <summary>
        /// Updates an orphan recording to a regular recording with retention values
        /// </summary>
        /// <remarks>
        /// If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Recording</returns>
        ApiResponse<Recording> PutOrphanIdWithHttpInfo (string orphanId, OrphanUpdateRequest body = null);
        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>KeyRotationSchedule</returns>
        KeyRotationSchedule PutRecordingkeysRotationschedule (KeyRotationSchedule body);

        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        ApiResponse<KeyRotationSchedule> PutRecordingkeysRotationscheduleWithHttpInfo (KeyRotationSchedule body);
        /// <summary>
        /// Update the Recording Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Recording settings</param>
        /// <returns>RecordingSettings</returns>
        RecordingSettings PutSettings (RecordingSettings body);

        /// <summary>
        /// Update the Recording Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Recording settings</param>
        /// <returns>ApiResponse of RecordingSettings</returns>
        ApiResponse<RecordingSettings> PutSettingsWithHttpInfo (RecordingSettings body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
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
        System.Threading.Tasks.Task DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsync (string conversationId, string recordingId, string annotationId);

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
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId);
        /// <summary>
        /// Delete media retention policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteMediaretentionpoliciesAsync (string ids);

        /// <summary>
        /// Delete media retention policies
        /// </summary>
        /// <remarks>
        /// Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteMediaretentionpoliciesAsyncWithHttpInfo (string ids);
        /// <summary>
        /// Delete a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> DeleteMediaretentionpoliciesPolicyIdAsync (string policyId);

        /// <summary>
        /// Delete a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> DeleteMediaretentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId);
        /// <summary>
        /// Deletes a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of OrphanRecording</returns>
        System.Threading.Tasks.Task<OrphanRecording> DeleteOrphanIdAsync (string orphanId);

        /// <summary>
        /// Deletes a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of ApiResponse (OrphanRecording)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrphanRecording>> DeleteOrphanIdAsyncWithHttpInfo (string orphanId);
        /// <summary>
        /// Get all of a Conversation&#39;s Recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional, default to 5000)</param>
        /// <param name="formatId">The desired media format (optional, default to WEBM)</param>
        /// <returns>Task of List&lt;Recording&gt;</returns>
        System.Threading.Tasks.Task<List<Recording>> GetConversationIdRecordingsAsync (string conversationId, int? maxWaitMs = null, string formatId = null);

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional, default to 5000)</param>
        /// <param name="formatId">The desired media format (optional, default to WEBM)</param>
        /// <returns>Task of ApiResponse (List&lt;Recording&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Recording>>> GetConversationIdRecordingsAsyncWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null);
        /// <summary>
        /// Gets a specific recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>Task of Recording</returns>
        System.Threading.Tasks.Task<Recording> GetConversationIdRecordingsRecordingIdAsync (string conversationId, string recordingId, string formatId = null, bool? download = null, string fileName = null);

        /// <summary>
        /// Gets a specific recording.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>Task of ApiResponse (Recording)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recording>> GetConversationIdRecordingsRecordingIdAsyncWithHttpInfo (string conversationId, string recordingId, string formatId = null, bool? download = null, string fileName = null);
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
        System.Threading.Tasks.Task<List<Annotation>> GetConversationIdRecordingsRecordingIdAnnotationsAsync (string conversationId, string recordingId);

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
        System.Threading.Tasks.Task<ApiResponse<List<Annotation>>> GetConversationIdRecordingsRecordingIdAnnotationsAsyncWithHttpInfo (string conversationId, string recordingId);
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
        System.Threading.Tasks.Task<Annotation> GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsync (string conversationId, string recordingId, string annotationId);

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
        System.Threading.Tasks.Task<ApiResponse<Annotation>> GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId);
        /// <summary>
        /// gets a list local key settings data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of LocalEncryptionConfigurationListing</returns>
        System.Threading.Tasks.Task<LocalEncryptionConfigurationListing> GetLocalkeysSettingsAsync ();

        /// <summary>
        /// gets a list local key settings data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (LocalEncryptionConfigurationListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocalEncryptionConfigurationListing>> GetLocalkeysSettingsAsyncWithHttpInfo ();
        /// <summary>
        /// Get the local encryption settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <returns>Task of LocalEncryptionConfiguration</returns>
        System.Threading.Tasks.Task<LocalEncryptionConfiguration> GetLocalkeysSettingsSettingsIdAsync (string settingsId);

        /// <summary>
        /// Get the local encryption settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <returns>Task of ApiResponse (LocalEncryptionConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocalEncryptionConfiguration>> GetLocalkeysSettingsSettingsIdAsyncWithHttpInfo (string settingsId);
        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary&#x3D;true to this endpoint
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <returns>Task of PolicyEntityListing</returns>
        System.Threading.Tasks.Task<PolicyEntityListing> GetMediaretentionpoliciesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled.
        /// </summary>
        /// <remarks>
        /// for a less verbose response, add summary&#x3D;true to this endpoint
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <returns>Task of ApiResponse (PolicyEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<PolicyEntityListing>> GetMediaretentionpoliciesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null);
        /// <summary>
        /// Get a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> GetMediaretentionpoliciesPolicyIdAsync (string policyId);

        /// <summary>
        /// Get a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> GetMediaretentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId);
        /// <summary>
        /// Gets a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of OrphanRecording</returns>
        System.Threading.Tasks.Task<OrphanRecording> GetOrphanIdAsync (string orphanId);

        /// <summary>
        /// Gets a single orphan recording
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of ApiResponse (OrphanRecording)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrphanRecording>> GetOrphanIdAsyncWithHttpInfo (string orphanId);
        /// <summary>
        /// Gets the media of a single orphan recording
        /// </summary>
        /// <remarks>
        /// A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>Task of Recording</returns>
        System.Threading.Tasks.Task<Recording> GetOrphanIdMediaAsync (string orphanId, string formatId = null, bool? download = null, string fileName = null);

        /// <summary>
        /// Gets the media of a single orphan recording
        /// </summary>
        /// <remarks>
        /// A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>Task of ApiResponse (Recording)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recording>> GetOrphanIdMediaAsyncWithHttpInfo (string orphanId, string formatId = null, bool? download = null, string fileName = null);
        /// <summary>
        /// Gets all orphan recordings
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
        /// <param name="hasConversation">Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional, default to false)</param>
        /// <returns>Task of OrphanRecordingListing</returns>
        System.Threading.Tasks.Task<OrphanRecordingListing> GetOrphanrecordingsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null);

        /// <summary>
        /// Gets all orphan recordings
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
        /// <param name="hasConversation">Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (OrphanRecordingListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<OrphanRecordingListing>> GetOrphanrecordingsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null);
        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of EncryptionKeyEntityListing</returns>
        System.Threading.Tasks.Task<EncryptionKeyEntityListing> GetRecordingkeysAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Get encryption key list
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EncryptionKeyEntityListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<EncryptionKeyEntityListing>> GetRecordingkeysAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of KeyRotationSchedule</returns>
        System.Threading.Tasks.Task<KeyRotationSchedule> GetRecordingkeysRotationscheduleAsync ();

        /// <summary>
        /// Get key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> GetRecordingkeysRotationscheduleAsyncWithHttpInfo ();
        /// <summary>
        /// Get the Recording Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDefault">If no settings are found, a new one is created with default values (optional, default to false)</param>
        /// <returns>Task of RecordingSettings</returns>
        System.Threading.Tasks.Task<RecordingSettings> GetSettingsAsync (bool? createDefault = null);

        /// <summary>
        /// Get the Recording Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDefault">If no settings are found, a new one is created with default values (optional, default to false)</param>
        /// <returns>Task of ApiResponse (RecordingSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecordingSettings>> GetSettingsAsyncWithHttpInfo (bool? createDefault = null);
        /// <summary>
        /// Retrieves a paged listing of screen recording sessions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ScreenRecordingSessionListing</returns>
        System.Threading.Tasks.Task<ScreenRecordingSessionListing> GetsScreensessionsAsync (int? pageSize = null, int? pageNumber = null);

        /// <summary>
        /// Retrieves a paged listing of screen recording sessions
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (ScreenRecordingSessionListing)</returns>
        System.Threading.Tasks.Task<ApiResponse<ScreenRecordingSessionListing>> GetsScreensessionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null);
        /// <summary>
        /// Patch a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PatchMediaretentionpoliciesPolicyIdAsync (string policyId, Policy body);

        /// <summary>
        /// Patch a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PatchMediaretentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId, Policy body);
        /// <summary>
        /// Update a screen recording session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingSessionId">Screen recording session ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task PatchsScreensessionsRecordingsessionIdAsync (string recordingSessionId, ScreenRecordingSessionRequest body = null);

        /// <summary>
        /// Update a screen recording session
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingSessionId">Screen recording session ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> PatchsScreensessionsRecordingsessionIdAsyncWithHttpInfo (string recordingSessionId, ScreenRecordingSessionRequest body = null);
        /// <summary>
        /// Create annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of Annotation</returns>
        System.Threading.Tasks.Task<Annotation> PostConversationIdRecordingsRecordingIdAnnotationsAsync (string conversationId, string recordingId, Annotation body);

        /// <summary>
        /// Create annotation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Annotation>> PostConversationIdRecordingsRecordingIdAnnotationsAsyncWithHttpInfo (string conversationId, string recordingId, Annotation body);
        /// <summary>
        /// create a local recording key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption body</param>
        /// <returns>Task of EncryptionKey</returns>
        System.Threading.Tasks.Task<EncryptionKey> PostLocalkeysAsync (LocalEncryptionKeyRequest body);

        /// <summary>
        /// create a local recording key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption body</param>
        /// <returns>Task of ApiResponse (EncryptionKey)</returns>
        System.Threading.Tasks.Task<ApiResponse<EncryptionKey>> PostLocalkeysAsyncWithHttpInfo (LocalEncryptionKeyRequest body);
        /// <summary>
        /// create settings for local key creation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption Configuration</param>
        /// <returns>Task of LocalEncryptionConfiguration</returns>
        System.Threading.Tasks.Task<LocalEncryptionConfiguration> PostLocalkeysSettingsAsync (LocalEncryptionConfiguration body);

        /// <summary>
        /// create settings for local key creation
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption Configuration</param>
        /// <returns>Task of ApiResponse (LocalEncryptionConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocalEncryptionConfiguration>> PostLocalkeysSettingsAsyncWithHttpInfo (LocalEncryptionConfiguration body);
        /// <summary>
        /// Create media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PostMediaretentionpoliciesAsync (PolicyCreate body);

        /// <summary>
        /// Create media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PostMediaretentionpoliciesAsyncWithHttpInfo (PolicyCreate body);
        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EncryptionKey</returns>
        System.Threading.Tasks.Task<EncryptionKey> PostRecordingkeysAsync ();

        /// <summary>
        /// Create encryption key
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EncryptionKey)</returns>
        System.Threading.Tasks.Task<ApiResponse<EncryptionKey>> PostRecordingkeysAsyncWithHttpInfo ();
        /// <summary>
        /// Updates the retention records on a recording.
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <returns>Task of Recording</returns>
        System.Threading.Tasks.Task<Recording> PutConversationIdRecordingsRecordingIdAsync (string conversationId, string recordingId, Recording body);

        /// <summary>
        /// Updates the retention records on a recording.
        /// </summary>
        /// <remarks>
        /// Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <returns>Task of ApiResponse (Recording)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recording>> PutConversationIdRecordingsRecordingIdAsyncWithHttpInfo (string conversationId, string recordingId, Recording body);
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
        /// <param name="body">annotation</param>
        /// <returns>Task of Annotation</returns>
        System.Threading.Tasks.Task<Annotation> PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsync (string conversationId, string recordingId, string annotationId, Annotation body);

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
        /// <param name="body">annotation</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        System.Threading.Tasks.Task<ApiResponse<Annotation>> PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body);
        /// <summary>
        /// Update the local encryption settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <param name="body">Local Encryption metadata</param>
        /// <returns>Task of LocalEncryptionConfiguration</returns>
        System.Threading.Tasks.Task<LocalEncryptionConfiguration> PutLocalkeysSettingsSettingsIdAsync (string settingsId, LocalEncryptionConfiguration body);

        /// <summary>
        /// Update the local encryption settings
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <param name="body">Local Encryption metadata</param>
        /// <returns>Task of ApiResponse (LocalEncryptionConfiguration)</returns>
        System.Threading.Tasks.Task<ApiResponse<LocalEncryptionConfiguration>> PutLocalkeysSettingsSettingsIdAsyncWithHttpInfo (string settingsId, LocalEncryptionConfiguration body);
        /// <summary>
        /// Update a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        System.Threading.Tasks.Task<Policy> PutMediaretentionpoliciesPolicyIdAsync (string policyId, Policy body);

        /// <summary>
        /// Update a media retention policy
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        System.Threading.Tasks.Task<ApiResponse<Policy>> PutMediaretentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId, Policy body);
        /// <summary>
        /// Updates an orphan recording to a regular recording with retention values
        /// </summary>
        /// <remarks>
        /// If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Recording</returns>
        System.Threading.Tasks.Task<Recording> PutOrphanIdAsync (string orphanId, OrphanUpdateRequest body = null);

        /// <summary>
        /// Updates an orphan recording to a regular recording with retention values
        /// </summary>
        /// <remarks>
        /// If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Recording)</returns>
        System.Threading.Tasks.Task<ApiResponse<Recording>> PutOrphanIdAsyncWithHttpInfo (string orphanId, OrphanUpdateRequest body = null);
        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of KeyRotationSchedule</returns>
        System.Threading.Tasks.Task<KeyRotationSchedule> PutRecordingkeysRotationscheduleAsync (KeyRotationSchedule body);

        /// <summary>
        /// Update key rotation schedule
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> PutRecordingkeysRotationscheduleAsyncWithHttpInfo (KeyRotationSchedule body);
        /// <summary>
        /// Update the Recording Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Recording settings</param>
        /// <returns>Task of RecordingSettings</returns>
        System.Threading.Tasks.Task<RecordingSettings> PutSettingsAsync (RecordingSettings body);

        /// <summary>
        /// Update the Recording Settings for the Organization
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Recording settings</param>
        /// <returns>Task of ApiResponse (RecordingSettings)</returns>
        System.Threading.Tasks.Task<ApiResponse<RecordingSettings>> PutSettingsAsyncWithHttpInfo (RecordingSettings body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class RecordingApi : IRecordingApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingApi"/> class.
        /// </summary>
        /// <returns></returns>
        public RecordingApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RecordingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public RecordingApi(Configuration configuration = null)
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
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
        /// Delete annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
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
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling RecordingApi->DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
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
        public async System.Threading.Tasks.Task DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsync (string conversationId, string recordingId, string annotationId)
        {
             await DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo(conversationId, recordingId, annotationId);

        }

        /// <summary>
        /// Delete annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling RecordingApi->DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
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
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Delete media retention policies Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>string</returns>
        public string DeleteMediaretentionpolicies (string ids)
        {
             ApiResponse<string> localVarResponse = DeleteMediaretentionpoliciesWithHttpInfo(ids);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete media retention policies Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteMediaretentionpoliciesWithHttpInfo (string ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                throw new ApiException(400, "Missing required parameter 'ids' when calling RecordingApi->DeleteMediaretentionpolicies");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies";
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
            if (ids != null) localVarQueryParams.Add("ids", Configuration.ApiClient.ParameterToString(ids)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete media retention policies Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteMediaretentionpoliciesAsync (string ids)
        {
             ApiResponse<string> localVarResponse = await DeleteMediaretentionpoliciesAsyncWithHttpInfo(ids);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete media retention policies Bulk delete of media retention policies, this will only delete the polices that match the ids specified in the query param.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="ids"></param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteMediaretentionpoliciesAsyncWithHttpInfo (string ids)
        {
            // verify the required parameter 'ids' is set
            if (ids == null)
                throw new ApiException(400, "Missing required parameter 'ids' when calling RecordingApi->DeleteMediaretentionpolicies");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies";
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
            if (ids != null) localVarQueryParams.Add("ids", Configuration.ApiClient.ParameterToString(ids)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>string</returns>
        public string DeleteMediaretentionpoliciesPolicyId (string policyId)
        {
             ApiResponse<string> localVarResponse = DeleteMediaretentionpoliciesPolicyIdWithHttpInfo(policyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > DeleteMediaretentionpoliciesPolicyIdWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->DeleteMediaretentionpoliciesPolicyId");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteMediaretentionpoliciesPolicyId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMediaretentionpoliciesPolicyId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Delete a media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> DeleteMediaretentionpoliciesPolicyIdAsync (string policyId)
        {
             ApiResponse<string> localVarResponse = await DeleteMediaretentionpoliciesPolicyIdAsyncWithHttpInfo(policyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> DeleteMediaretentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->DeleteMediaretentionpoliciesPolicyId");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteMediaretentionpoliciesPolicyId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteMediaretentionpoliciesPolicyId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (string) Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
            
        }

        /// <summary>
        /// Deletes a single orphan recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>OrphanRecording</returns>
        public OrphanRecording DeleteOrphanId (string orphanId)
        {
             ApiResponse<OrphanRecording> localVarResponse = DeleteOrphanIdWithHttpInfo(orphanId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Deletes a single orphan recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>ApiResponse of OrphanRecording</returns>
        public ApiResponse< OrphanRecording > DeleteOrphanIdWithHttpInfo (string orphanId)
        {
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling RecordingApi->DeleteOrphanId");

            var localVarPath = "/api/v2/orphanrecordings/{orphanId}";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", Configuration.ApiClient.ParameterToString(orphanId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrphanId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrphanId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrphanRecording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecording)));
            
        }

        /// <summary>
        /// Deletes a single orphan recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of OrphanRecording</returns>
        public async System.Threading.Tasks.Task<OrphanRecording> DeleteOrphanIdAsync (string orphanId)
        {
             ApiResponse<OrphanRecording> localVarResponse = await DeleteOrphanIdAsyncWithHttpInfo(orphanId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Deletes a single orphan recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of ApiResponse (OrphanRecording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrphanRecording>> DeleteOrphanIdAsyncWithHttpInfo (string orphanId)
        {
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling RecordingApi->DeleteOrphanId");

            var localVarPath = "/api/v2/orphanrecordings/{orphanId}";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", Configuration.ApiClient.ParameterToString(orphanId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrphanId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling DeleteOrphanId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrphanRecording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecording)));
            
        }

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional, default to 5000)</param>
        /// <param name="formatId">The desired media format (optional, default to WEBM)</param>
        /// <returns>List&lt;Recording&gt;</returns>
        public List<Recording> GetConversationIdRecordings (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
             ApiResponse<List<Recording>> localVarResponse = GetConversationIdRecordingsWithHttpInfo(conversationId, maxWaitMs, formatId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional, default to 5000)</param>
        /// <param name="formatId">The desired media format (optional, default to WEBM)</param>
        /// <returns>ApiResponse of List&lt;Recording&gt;</returns>
        public ApiResponse< List<Recording> > GetConversationIdRecordingsWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationIdRecordings");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings";
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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdRecordings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdRecordings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Recording>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Recording>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Recording>)));
            
        }

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional, default to 5000)</param>
        /// <param name="formatId">The desired media format (optional, default to WEBM)</param>
        /// <returns>Task of List&lt;Recording&gt;</returns>
        public async System.Threading.Tasks.Task<List<Recording>> GetConversationIdRecordingsAsync (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
             ApiResponse<List<Recording>> localVarResponse = await GetConversationIdRecordingsAsyncWithHttpInfo(conversationId, maxWaitMs, formatId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all of a Conversation&#39;s Recordings. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="maxWaitMs">The maximum number of milliseconds to wait for the recording to be ready. Must be a positive value. (optional, default to 5000)</param>
        /// <param name="formatId">The desired media format (optional, default to WEBM)</param>
        /// <returns>Task of ApiResponse (List&lt;Recording&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Recording>>> GetConversationIdRecordingsAsyncWithHttpInfo (string conversationId, int? maxWaitMs = null, string formatId = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationIdRecordings");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings";
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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdRecordings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdRecordings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Recording>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Recording>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Recording>)));
            
        }

        /// <summary>
        /// Gets a specific recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>Recording</returns>
        public Recording GetConversationIdRecordingsRecordingId (string conversationId, string recordingId, string formatId = null, bool? download = null, string fileName = null)
        {
             ApiResponse<Recording> localVarResponse = GetConversationIdRecordingsRecordingIdWithHttpInfo(conversationId, recordingId, formatId, download, fileName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a specific recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>ApiResponse of Recording</returns>
        public ApiResponse< Recording > GetConversationIdRecordingsRecordingIdWithHttpInfo (string conversationId, string recordingId, string formatId = null, bool? download = null, string fileName = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationIdRecordingsRecordingId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->GetConversationIdRecordingsRecordingId");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdRecordingsRecordingId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdRecordingsRecordingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recording)));
            
        }

        /// <summary>
        /// Gets a specific recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>Task of Recording</returns>
        public async System.Threading.Tasks.Task<Recording> GetConversationIdRecordingsRecordingIdAsync (string conversationId, string recordingId, string formatId = null, bool? download = null, string fileName = null)
        {
             ApiResponse<Recording> localVarResponse = await GetConversationIdRecordingsRecordingIdAsyncWithHttpInfo(conversationId, recordingId, formatId, download, fileName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a specific recording. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>Task of ApiResponse (Recording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recording>> GetConversationIdRecordingsRecordingIdAsyncWithHttpInfo (string conversationId, string recordingId, string formatId = null, bool? download = null, string fileName = null)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationIdRecordingsRecordingId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->GetConversationIdRecordingsRecordingId");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdRecordingsRecordingId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdRecordingsRecordingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recording)));
            
        }

        /// <summary>
        /// Get annotations for recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>List&lt;Annotation&gt;</returns>
        public List<Annotation> GetConversationIdRecordingsRecordingIdAnnotations (string conversationId, string recordingId)
        {
             ApiResponse<List<Annotation>> localVarResponse = GetConversationIdRecordingsRecordingIdAnnotationsWithHttpInfo(conversationId, recordingId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get annotations for recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>ApiResponse of List&lt;Annotation&gt;</returns>
        public ApiResponse< List<Annotation> > GetConversationIdRecordingsRecordingIdAnnotationsWithHttpInfo (string conversationId, string recordingId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationIdRecordingsRecordingIdAnnotations");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->GetConversationIdRecordingsRecordingIdAnnotations");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations";
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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdRecordingsRecordingIdAnnotations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdRecordingsRecordingIdAnnotations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<List<Annotation>> GetConversationIdRecordingsRecordingIdAnnotationsAsync (string conversationId, string recordingId)
        {
             ApiResponse<List<Annotation>> localVarResponse = await GetConversationIdRecordingsRecordingIdAnnotationsAsyncWithHttpInfo(conversationId, recordingId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get annotations for recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <returns>Task of ApiResponse (List&lt;Annotation&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Annotation>>> GetConversationIdRecordingsRecordingIdAnnotationsAsyncWithHttpInfo (string conversationId, string recordingId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationIdRecordingsRecordingIdAnnotations");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->GetConversationIdRecordingsRecordingIdAnnotations");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations";
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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdRecordingsRecordingIdAnnotations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdRecordingsRecordingIdAnnotations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<List<Annotation>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Annotation>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Annotation>)));
            
        }

        /// <summary>
        /// Get annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <returns>Annotation</returns>
        public Annotation GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId (string conversationId, string recordingId, string annotationId)
        {
             ApiResponse<Annotation> localVarResponse = GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo(conversationId, recordingId, annotationId);
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
        public ApiResponse< Annotation > GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling RecordingApi->GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        public async System.Threading.Tasks.Task<Annotation> GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsync (string conversationId, string recordingId, string annotationId)
        {
             ApiResponse<Annotation> localVarResponse = await GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo(conversationId, recordingId, annotationId);
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
        public async System.Threading.Tasks.Task<ApiResponse<Annotation>> GetConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling RecordingApi->GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
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
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)));
            
        }

        /// <summary>
        /// gets a list local key settings data 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>LocalEncryptionConfigurationListing</returns>
        public LocalEncryptionConfigurationListing GetLocalkeysSettings ()
        {
             ApiResponse<LocalEncryptionConfigurationListing> localVarResponse = GetLocalkeysSettingsWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// gets a list local key settings data 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of LocalEncryptionConfigurationListing</returns>
        public ApiResponse< LocalEncryptionConfigurationListing > GetLocalkeysSettingsWithHttpInfo ()
        {

            var localVarPath = "/api/v2/recording/localkeys/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling GetLocalkeysSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocalkeysSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocalEncryptionConfigurationListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocalEncryptionConfigurationListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocalEncryptionConfigurationListing)));
            
        }

        /// <summary>
        /// gets a list local key settings data 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of LocalEncryptionConfigurationListing</returns>
        public async System.Threading.Tasks.Task<LocalEncryptionConfigurationListing> GetLocalkeysSettingsAsync ()
        {
             ApiResponse<LocalEncryptionConfigurationListing> localVarResponse = await GetLocalkeysSettingsAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// gets a list local key settings data 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (LocalEncryptionConfigurationListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocalEncryptionConfigurationListing>> GetLocalkeysSettingsAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/recording/localkeys/settings";
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
                throw new ApiException (localVarStatusCode, "Error calling GetLocalkeysSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocalkeysSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocalEncryptionConfigurationListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocalEncryptionConfigurationListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocalEncryptionConfigurationListing)));
            
        }

        /// <summary>
        /// Get the local encryption settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <returns>LocalEncryptionConfiguration</returns>
        public LocalEncryptionConfiguration GetLocalkeysSettingsSettingsId (string settingsId)
        {
             ApiResponse<LocalEncryptionConfiguration> localVarResponse = GetLocalkeysSettingsSettingsIdWithHttpInfo(settingsId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the local encryption settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <returns>ApiResponse of LocalEncryptionConfiguration</returns>
        public ApiResponse< LocalEncryptionConfiguration > GetLocalkeysSettingsSettingsIdWithHttpInfo (string settingsId)
        {
            // verify the required parameter 'settingsId' is set
            if (settingsId == null)
                throw new ApiException(400, "Missing required parameter 'settingsId' when calling RecordingApi->GetLocalkeysSettingsSettingsId");

            var localVarPath = "/api/v2/recording/localkeys/settings/{settingsId}";
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
            if (settingsId != null) localVarPathParams.Add("settingsId", Configuration.ApiClient.ParameterToString(settingsId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetLocalkeysSettingsSettingsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocalkeysSettingsSettingsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocalEncryptionConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocalEncryptionConfiguration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocalEncryptionConfiguration)));
            
        }

        /// <summary>
        /// Get the local encryption settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <returns>Task of LocalEncryptionConfiguration</returns>
        public async System.Threading.Tasks.Task<LocalEncryptionConfiguration> GetLocalkeysSettingsSettingsIdAsync (string settingsId)
        {
             ApiResponse<LocalEncryptionConfiguration> localVarResponse = await GetLocalkeysSettingsSettingsIdAsyncWithHttpInfo(settingsId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the local encryption settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <returns>Task of ApiResponse (LocalEncryptionConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocalEncryptionConfiguration>> GetLocalkeysSettingsSettingsIdAsyncWithHttpInfo (string settingsId)
        {
            // verify the required parameter 'settingsId' is set
            if (settingsId == null)
                throw new ApiException(400, "Missing required parameter 'settingsId' when calling RecordingApi->GetLocalkeysSettingsSettingsId");

            var localVarPath = "/api/v2/recording/localkeys/settings/{settingsId}";
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
            if (settingsId != null) localVarPathParams.Add("settingsId", Configuration.ApiClient.ParameterToString(settingsId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetLocalkeysSettingsSettingsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetLocalkeysSettingsSettingsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocalEncryptionConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocalEncryptionConfiguration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocalEncryptionConfiguration)));
            
        }

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled. for a less verbose response, add summary&#x3D;true to this endpoint
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <returns>PolicyEntityListing</returns>
        public PolicyEntityListing GetMediaretentionpolicies (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {
             ApiResponse<PolicyEntityListing> localVarResponse = GetMediaretentionpoliciesWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, name, enabled, summary, hasErrors);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled. for a less verbose response, add summary&#x3D;true to this endpoint
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <returns>ApiResponse of PolicyEntityListing</returns>
        public ApiResponse< PolicyEntityListing > GetMediaretentionpoliciesWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {

            var localVarPath = "/api/v2/recording/mediaretentionpolicies";
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
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            if (summary != null) localVarQueryParams.Add("summary", Configuration.ApiClient.ParameterToString(summary)); // query parameter
            if (hasErrors != null) localVarQueryParams.Add("hasErrors", Configuration.ApiClient.ParameterToString(hasErrors)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PolicyEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PolicyEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PolicyEntityListing)));
            
        }

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled. for a less verbose response, add summary&#x3D;true to this endpoint
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <returns>Task of PolicyEntityListing</returns>
        public async System.Threading.Tasks.Task<PolicyEntityListing> GetMediaretentionpoliciesAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {
             ApiResponse<PolicyEntityListing> localVarResponse = await GetMediaretentionpoliciesAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, name, enabled, summary, hasErrors);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets media retention policy list with query options to filter on name and enabled. for a less verbose response, add summary&#x3D;true to this endpoint
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="name">the policy name - used for filtering results in searches. (optional)</param>
        /// <param name="enabled">checks to see if policy is enabled - use enabled &#x3D; true or enabled &#x3D; false (optional)</param>
        /// <param name="summary">provides a less verbose response of policy lists. (optional, default to false)</param>
        /// <param name="hasErrors">provides a way to fetch all policies with errors or policies that do not have errors (optional)</param>
        /// <returns>Task of ApiResponse (PolicyEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PolicyEntityListing>> GetMediaretentionpoliciesAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, string name = null, bool? enabled = null, bool? summary = null, bool? hasErrors = null)
        {

            var localVarPath = "/api/v2/recording/mediaretentionpolicies";
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
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (name != null) localVarQueryParams.Add("name", Configuration.ApiClient.ParameterToString(name)); // query parameter
            if (enabled != null) localVarQueryParams.Add("enabled", Configuration.ApiClient.ParameterToString(enabled)); // query parameter
            if (summary != null) localVarQueryParams.Add("summary", Configuration.ApiClient.ParameterToString(summary)); // query parameter
            if (hasErrors != null) localVarQueryParams.Add("hasErrors", Configuration.ApiClient.ParameterToString(hasErrors)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<PolicyEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PolicyEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PolicyEntityListing)));
            
        }

        /// <summary>
        /// Get a media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Policy</returns>
        public Policy GetMediaretentionpoliciesPolicyId (string policyId)
        {
             ApiResponse<Policy> localVarResponse = GetMediaretentionpoliciesPolicyIdWithHttpInfo(policyId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > GetMediaretentionpoliciesPolicyIdWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->GetMediaretentionpoliciesPolicyId");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetMediaretentionpoliciesPolicyId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMediaretentionpoliciesPolicyId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        /// <summary>
        /// Get a media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> GetMediaretentionpoliciesPolicyIdAsync (string policyId)
        {
             ApiResponse<Policy> localVarResponse = await GetMediaretentionpoliciesPolicyIdAsyncWithHttpInfo(policyId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> GetMediaretentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->GetMediaretentionpoliciesPolicyId");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetMediaretentionpoliciesPolicyId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetMediaretentionpoliciesPolicyId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        /// <summary>
        /// Gets a single orphan recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>OrphanRecording</returns>
        public OrphanRecording GetOrphanId (string orphanId)
        {
             ApiResponse<OrphanRecording> localVarResponse = GetOrphanIdWithHttpInfo(orphanId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets a single orphan recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>ApiResponse of OrphanRecording</returns>
        public ApiResponse< OrphanRecording > GetOrphanIdWithHttpInfo (string orphanId)
        {
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling RecordingApi->GetOrphanId");

            var localVarPath = "/api/v2/orphanrecordings/{orphanId}";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", Configuration.ApiClient.ParameterToString(orphanId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrphanRecording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecording)));
            
        }

        /// <summary>
        /// Gets a single orphan recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of OrphanRecording</returns>
        public async System.Threading.Tasks.Task<OrphanRecording> GetOrphanIdAsync (string orphanId)
        {
             ApiResponse<OrphanRecording> localVarResponse = await GetOrphanIdAsyncWithHttpInfo(orphanId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets a single orphan recording 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <returns>Task of ApiResponse (OrphanRecording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrphanRecording>> GetOrphanIdAsyncWithHttpInfo (string orphanId)
        {
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling RecordingApi->GetOrphanId");

            var localVarPath = "/api/v2/orphanrecordings/{orphanId}";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", Configuration.ApiClient.ParameterToString(orphanId)); // path parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrphanRecording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecording)));
            
        }

        /// <summary>
        /// Gets the media of a single orphan recording A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>Recording</returns>
        public Recording GetOrphanIdMedia (string orphanId, string formatId = null, bool? download = null, string fileName = null)
        {
             ApiResponse<Recording> localVarResponse = GetOrphanIdMediaWithHttpInfo(orphanId, formatId, download, fileName);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets the media of a single orphan recording A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>ApiResponse of Recording</returns>
        public ApiResponse< Recording > GetOrphanIdMediaWithHttpInfo (string orphanId, string formatId = null, bool? download = null, string fileName = null)
        {
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling RecordingApi->GetOrphanIdMedia");

            var localVarPath = "/api/v2/orphanrecordings/{orphanId}/media";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", Configuration.ApiClient.ParameterToString(orphanId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanIdMedia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanIdMedia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recording)));
            
        }

        /// <summary>
        /// Gets the media of a single orphan recording A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>Task of Recording</returns>
        public async System.Threading.Tasks.Task<Recording> GetOrphanIdMediaAsync (string orphanId, string formatId = null, bool? download = null, string fileName = null)
        {
             ApiResponse<Recording> localVarResponse = await GetOrphanIdMediaAsyncWithHttpInfo(orphanId, formatId, download, fileName);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets the media of a single orphan recording A 202 response means the orphaned media is currently transcoding and will be available shortly.A 200 response denotes the transcoded orphan media is available now and is contained in the response body.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="formatId">The desired media format. (optional, default to WEBM)</param>
        /// <param name="download">requesting a download format of the recording (optional, default to false)</param>
        /// <param name="fileName">the name of the downloaded fileName (optional)</param>
        /// <returns>Task of ApiResponse (Recording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recording>> GetOrphanIdMediaAsyncWithHttpInfo (string orphanId, string formatId = null, bool? download = null, string fileName = null)
        {
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling RecordingApi->GetOrphanIdMedia");

            var localVarPath = "/api/v2/orphanrecordings/{orphanId}/media";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", Configuration.ApiClient.ParameterToString(orphanId)); // path parameter
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
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanIdMedia: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanIdMedia: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recording)));
            
        }

        /// <summary>
        /// Gets all orphan recordings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="hasConversation">Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional, default to false)</param>
        /// <returns>OrphanRecordingListing</returns>
        public OrphanRecordingListing GetOrphanrecordings (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null)
        {
             ApiResponse<OrphanRecordingListing> localVarResponse = GetOrphanrecordingsWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, hasConversation);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Gets all orphan recordings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="hasConversation">Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional, default to false)</param>
        /// <returns>ApiResponse of OrphanRecordingListing</returns>
        public ApiResponse< OrphanRecordingListing > GetOrphanrecordingsWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null)
        {

            var localVarPath = "/api/v2/orphanrecordings";
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
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (hasConversation != null) localVarQueryParams.Add("hasConversation", Configuration.ApiClient.ParameterToString(hasConversation)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanrecordings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanrecordings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecordingListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrphanRecordingListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecordingListing)));
            
        }

        /// <summary>
        /// Gets all orphan recordings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="hasConversation">Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional, default to false)</param>
        /// <returns>Task of OrphanRecordingListing</returns>
        public async System.Threading.Tasks.Task<OrphanRecordingListing> GetOrphanrecordingsAsync (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null)
        {
             ApiResponse<OrphanRecordingListing> localVarResponse = await GetOrphanrecordingsAsyncWithHttpInfo(pageSize, pageNumber, sortBy, expand, nextPage, previousPage, hasConversation);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Gets all orphan recordings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">The total page size requested (optional, default to 25)</param>
        /// <param name="pageNumber">The page number requested (optional, default to 1)</param>
        /// <param name="sortBy">variable name requested to sort by (optional)</param>
        /// <param name="expand">variable name requested by expand list (optional)</param>
        /// <param name="nextPage">next page token (optional)</param>
        /// <param name="previousPage">Previous page token (optional)</param>
        /// <param name="hasConversation">Filter resulting orphans by whether the conversation is known. False returns all orphans for the organization. (optional, default to false)</param>
        /// <returns>Task of ApiResponse (OrphanRecordingListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OrphanRecordingListing>> GetOrphanrecordingsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null, string sortBy = null, List<Object> expand = null, string nextPage = null, string previousPage = null, bool? hasConversation = null)
        {

            var localVarPath = "/api/v2/orphanrecordings";
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
            if (nextPage != null) localVarQueryParams.Add("nextPage", Configuration.ApiClient.ParameterToString(nextPage)); // query parameter
            if (previousPage != null) localVarQueryParams.Add("previousPage", Configuration.ApiClient.ParameterToString(previousPage)); // query parameter
            if (hasConversation != null) localVarQueryParams.Add("hasConversation", Configuration.ApiClient.ParameterToString(hasConversation)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanrecordings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetOrphanrecordings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<OrphanRecordingListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (OrphanRecordingListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(OrphanRecordingListing)));
            
        }

        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>EncryptionKeyEntityListing</returns>
        public EncryptionKeyEntityListing GetRecordingkeys (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EncryptionKeyEntityListing> localVarResponse = GetRecordingkeysWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of EncryptionKeyEntityListing</returns>
        public ApiResponse< EncryptionKeyEntityListing > GetRecordingkeysWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/recording/recordingkeys";
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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingkeys: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingkeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKeyEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKeyEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKeyEntityListing)));
            
        }

        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of EncryptionKeyEntityListing</returns>
        public async System.Threading.Tasks.Task<EncryptionKeyEntityListing> GetRecordingkeysAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<EncryptionKeyEntityListing> localVarResponse = await GetRecordingkeysAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get encryption key list 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (EncryptionKeyEntityListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EncryptionKeyEntityListing>> GetRecordingkeysAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/recording/recordingkeys";
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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingkeys: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingkeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKeyEntityListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKeyEntityListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKeyEntityListing)));
            
        }

        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>KeyRotationSchedule</returns>
        public KeyRotationSchedule GetRecordingkeysRotationschedule ()
        {
             ApiResponse<KeyRotationSchedule> localVarResponse = GetRecordingkeysRotationscheduleWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        public ApiResponse< KeyRotationSchedule > GetRecordingkeysRotationscheduleWithHttpInfo ()
        {

            var localVarPath = "/api/v2/recording/recordingkeys/rotationschedule";
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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingkeysRotationschedule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingkeysRotationschedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeyRotationSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeyRotationSchedule)));
            
        }

        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of KeyRotationSchedule</returns>
        public async System.Threading.Tasks.Task<KeyRotationSchedule> GetRecordingkeysRotationscheduleAsync ()
        {
             ApiResponse<KeyRotationSchedule> localVarResponse = await GetRecordingkeysRotationscheduleAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> GetRecordingkeysRotationscheduleAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/recording/recordingkeys/rotationschedule";
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
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingkeysRotationschedule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetRecordingkeysRotationschedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeyRotationSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeyRotationSchedule)));
            
        }

        /// <summary>
        /// Get the Recording Settings for the Organization 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDefault">If no settings are found, a new one is created with default values (optional, default to false)</param>
        /// <returns>RecordingSettings</returns>
        public RecordingSettings GetSettings (bool? createDefault = null)
        {
             ApiResponse<RecordingSettings> localVarResponse = GetSettingsWithHttpInfo(createDefault);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the Recording Settings for the Organization 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDefault">If no settings are found, a new one is created with default values (optional, default to false)</param>
        /// <returns>ApiResponse of RecordingSettings</returns>
        public ApiResponse< RecordingSettings > GetSettingsWithHttpInfo (bool? createDefault = null)
        {

            var localVarPath = "/api/v2/recording/settings";
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
            if (createDefault != null) localVarQueryParams.Add("createDefault", Configuration.ApiClient.ParameterToString(createDefault)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RecordingSettings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingSettings)));
            
        }

        /// <summary>
        /// Get the Recording Settings for the Organization 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDefault">If no settings are found, a new one is created with default values (optional, default to false)</param>
        /// <returns>Task of RecordingSettings</returns>
        public async System.Threading.Tasks.Task<RecordingSettings> GetSettingsAsync (bool? createDefault = null)
        {
             ApiResponse<RecordingSettings> localVarResponse = await GetSettingsAsyncWithHttpInfo(createDefault);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get the Recording Settings for the Organization 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createDefault">If no settings are found, a new one is created with default values (optional, default to false)</param>
        /// <returns>Task of ApiResponse (RecordingSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordingSettings>> GetSettingsAsyncWithHttpInfo (bool? createDefault = null)
        {

            var localVarPath = "/api/v2/recording/settings";
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
            if (createDefault != null) localVarQueryParams.Add("createDefault", Configuration.ApiClient.ParameterToString(createDefault)); // query parameter

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
                throw new ApiException (localVarStatusCode, "Error calling GetSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RecordingSettings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingSettings)));
            
        }

        /// <summary>
        /// Retrieves a paged listing of screen recording sessions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ScreenRecordingSessionListing</returns>
        public ScreenRecordingSessionListing GetsScreensessions (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<ScreenRecordingSessionListing> localVarResponse = GetsScreensessionsWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a paged listing of screen recording sessions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>ApiResponse of ScreenRecordingSessionListing</returns>
        public ApiResponse< ScreenRecordingSessionListing > GetsScreensessionsWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/recordings/screensessions";
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
                throw new ApiException (localVarStatusCode, "Error calling GetsScreensessions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetsScreensessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScreenRecordingSessionListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScreenRecordingSessionListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScreenRecordingSessionListing)));
            
        }

        /// <summary>
        /// Retrieves a paged listing of screen recording sessions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ScreenRecordingSessionListing</returns>
        public async System.Threading.Tasks.Task<ScreenRecordingSessionListing> GetsScreensessionsAsync (int? pageSize = null, int? pageNumber = null)
        {
             ApiResponse<ScreenRecordingSessionListing> localVarResponse = await GetsScreensessionsAsyncWithHttpInfo(pageSize, pageNumber);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves a paged listing of screen recording sessions 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="pageSize">Page size (optional, default to 25)</param>
        /// <param name="pageNumber">Page number (optional, default to 1)</param>
        /// <returns>Task of ApiResponse (ScreenRecordingSessionListing)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ScreenRecordingSessionListing>> GetsScreensessionsAsyncWithHttpInfo (int? pageSize = null, int? pageNumber = null)
        {

            var localVarPath = "/api/v2/recordings/screensessions";
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
                throw new ApiException (localVarStatusCode, "Error calling GetsScreensessions: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling GetsScreensessions: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<ScreenRecordingSessionListing>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (ScreenRecordingSessionListing) Configuration.ApiClient.Deserialize(localVarResponse, typeof(ScreenRecordingSessionListing)));
            
        }

        /// <summary>
        /// Patch a media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        public Policy PatchMediaretentionpoliciesPolicyId (string policyId, Policy body)
        {
             ApiResponse<Policy> localVarResponse = PatchMediaretentionpoliciesPolicyIdWithHttpInfo(policyId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Patch a media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PatchMediaretentionpoliciesPolicyIdWithHttpInfo (string policyId, Policy body)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->PatchMediaretentionpoliciesPolicyId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PatchMediaretentionpoliciesPolicyId");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchMediaretentionpoliciesPolicyId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchMediaretentionpoliciesPolicyId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        /// <summary>
        /// Patch a media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> PatchMediaretentionpoliciesPolicyIdAsync (string policyId, Policy body)
        {
             ApiResponse<Policy> localVarResponse = await PatchMediaretentionpoliciesPolicyIdAsyncWithHttpInfo(policyId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Patch a media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PatchMediaretentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId, Policy body)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->PatchMediaretentionpoliciesPolicyId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PatchMediaretentionpoliciesPolicyId");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchMediaretentionpoliciesPolicyId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchMediaretentionpoliciesPolicyId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        /// <summary>
        /// Update a screen recording session 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingSessionId">Screen recording session ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns></returns>
        public void PatchsScreensessionsRecordingsessionId (string recordingSessionId, ScreenRecordingSessionRequest body = null)
        {
             PatchsScreensessionsRecordingsessionIdWithHttpInfo(recordingSessionId, body);
        }

        /// <summary>
        /// Update a screen recording session 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingSessionId">Screen recording session ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> PatchsScreensessionsRecordingsessionIdWithHttpInfo (string recordingSessionId, ScreenRecordingSessionRequest body = null)
        {
            // verify the required parameter 'recordingSessionId' is set
            if (recordingSessionId == null)
                throw new ApiException(400, "Missing required parameter 'recordingSessionId' when calling RecordingApi->PatchsScreensessionsRecordingsessionId");

            var localVarPath = "/api/v2/recordings/screensessions/{recordingSessionId}";
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
            if (recordingSessionId != null) localVarPathParams.Add("recordingSessionId", Configuration.ApiClient.ParameterToString(recordingSessionId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchsScreensessionsRecordingsessionId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchsScreensessionsRecordingsessionId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Update a screen recording session 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingSessionId">Screen recording session ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task PatchsScreensessionsRecordingsessionIdAsync (string recordingSessionId, ScreenRecordingSessionRequest body = null)
        {
             await PatchsScreensessionsRecordingsessionIdAsyncWithHttpInfo(recordingSessionId, body);

        }

        /// <summary>
        /// Update a screen recording session 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recordingSessionId">Screen recording session ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> PatchsScreensessionsRecordingsessionIdAsyncWithHttpInfo (string recordingSessionId, ScreenRecordingSessionRequest body = null)
        {
            // verify the required parameter 'recordingSessionId' is set
            if (recordingSessionId == null)
                throw new ApiException(400, "Missing required parameter 'recordingSessionId' when calling RecordingApi->PatchsScreensessionsRecordingsessionId");

            var localVarPath = "/api/v2/recordings/screensessions/{recordingSessionId}";
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
            if (recordingSessionId != null) localVarPathParams.Add("recordingSessionId", Configuration.ApiClient.ParameterToString(recordingSessionId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                Method.PATCH, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (localVarStatusCode >= 400)
                throw new ApiException (localVarStatusCode, "Error calling PatchsScreensessionsRecordingsessionId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PatchsScreensessionsRecordingsessionId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            
            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Create annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Annotation</returns>
        public Annotation PostConversationIdRecordingsRecordingIdAnnotations (string conversationId, string recordingId, Annotation body)
        {
             ApiResponse<Annotation> localVarResponse = PostConversationIdRecordingsRecordingIdAnnotationsWithHttpInfo(conversationId, recordingId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>ApiResponse of Annotation</returns>
        public ApiResponse< Annotation > PostConversationIdRecordingsRecordingIdAnnotationsWithHttpInfo (string conversationId, string recordingId, Annotation body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->PostConversationIdRecordingsRecordingIdAnnotations");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->PostConversationIdRecordingsRecordingIdAnnotations");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostConversationIdRecordingsRecordingIdAnnotations");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdRecordingsRecordingIdAnnotations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdRecordingsRecordingIdAnnotations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="body">annotation</param>
        /// <returns>Task of Annotation</returns>
        public async System.Threading.Tasks.Task<Annotation> PostConversationIdRecordingsRecordingIdAnnotationsAsync (string conversationId, string recordingId, Annotation body)
        {
             ApiResponse<Annotation> localVarResponse = await PostConversationIdRecordingsRecordingIdAnnotationsAsyncWithHttpInfo(conversationId, recordingId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Annotation>> PostConversationIdRecordingsRecordingIdAnnotationsAsyncWithHttpInfo (string conversationId, string recordingId, Annotation body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->PostConversationIdRecordingsRecordingIdAnnotations");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->PostConversationIdRecordingsRecordingIdAnnotations");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostConversationIdRecordingsRecordingIdAnnotations");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdRecordingsRecordingIdAnnotations: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostConversationIdRecordingsRecordingIdAnnotations: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)));
            
        }

        /// <summary>
        /// create a local recording key 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption body</param>
        /// <returns>EncryptionKey</returns>
        public EncryptionKey PostLocalkeys (LocalEncryptionKeyRequest body)
        {
             ApiResponse<EncryptionKey> localVarResponse = PostLocalkeysWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// create a local recording key 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption body</param>
        /// <returns>ApiResponse of EncryptionKey</returns>
        public ApiResponse< EncryptionKey > PostLocalkeysWithHttpInfo (LocalEncryptionKeyRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostLocalkeys");

            var localVarPath = "/api/v2/recording/localkeys";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostLocalkeys: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLocalkeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKey)));
            
        }

        /// <summary>
        /// create a local recording key 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption body</param>
        /// <returns>Task of EncryptionKey</returns>
        public async System.Threading.Tasks.Task<EncryptionKey> PostLocalkeysAsync (LocalEncryptionKeyRequest body)
        {
             ApiResponse<EncryptionKey> localVarResponse = await PostLocalkeysAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// create a local recording key 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption body</param>
        /// <returns>Task of ApiResponse (EncryptionKey)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EncryptionKey>> PostLocalkeysAsyncWithHttpInfo (LocalEncryptionKeyRequest body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostLocalkeys");

            var localVarPath = "/api/v2/recording/localkeys";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostLocalkeys: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLocalkeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKey)));
            
        }

        /// <summary>
        /// create settings for local key creation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption Configuration</param>
        /// <returns>LocalEncryptionConfiguration</returns>
        public LocalEncryptionConfiguration PostLocalkeysSettings (LocalEncryptionConfiguration body)
        {
             ApiResponse<LocalEncryptionConfiguration> localVarResponse = PostLocalkeysSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// create settings for local key creation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption Configuration</param>
        /// <returns>ApiResponse of LocalEncryptionConfiguration</returns>
        public ApiResponse< LocalEncryptionConfiguration > PostLocalkeysSettingsWithHttpInfo (LocalEncryptionConfiguration body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostLocalkeysSettings");

            var localVarPath = "/api/v2/recording/localkeys/settings";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostLocalkeysSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLocalkeysSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocalEncryptionConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocalEncryptionConfiguration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocalEncryptionConfiguration)));
            
        }

        /// <summary>
        /// create settings for local key creation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption Configuration</param>
        /// <returns>Task of LocalEncryptionConfiguration</returns>
        public async System.Threading.Tasks.Task<LocalEncryptionConfiguration> PostLocalkeysSettingsAsync (LocalEncryptionConfiguration body)
        {
             ApiResponse<LocalEncryptionConfiguration> localVarResponse = await PostLocalkeysSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// create settings for local key creation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Local Encryption Configuration</param>
        /// <returns>Task of ApiResponse (LocalEncryptionConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocalEncryptionConfiguration>> PostLocalkeysSettingsAsyncWithHttpInfo (LocalEncryptionConfiguration body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostLocalkeysSettings");

            var localVarPath = "/api/v2/recording/localkeys/settings";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostLocalkeysSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostLocalkeysSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocalEncryptionConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocalEncryptionConfiguration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocalEncryptionConfiguration)));
            
        }

        /// <summary>
        /// Create media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        public Policy PostMediaretentionpolicies (PolicyCreate body)
        {
             ApiResponse<Policy> localVarResponse = PostMediaretentionpoliciesWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PostMediaretentionpoliciesWithHttpInfo (PolicyCreate body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostMediaretentionpolicies");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        /// <summary>
        /// Create media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> PostMediaretentionpoliciesAsync (PolicyCreate body)
        {
             ApiResponse<Policy> localVarResponse = await PostMediaretentionpoliciesAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PostMediaretentionpoliciesAsyncWithHttpInfo (PolicyCreate body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PostMediaretentionpolicies");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PostMediaretentionpolicies: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostMediaretentionpolicies: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>EncryptionKey</returns>
        public EncryptionKey PostRecordingkeys ()
        {
             ApiResponse<EncryptionKey> localVarResponse = PostRecordingkeysWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of EncryptionKey</returns>
        public ApiResponse< EncryptionKey > PostRecordingkeysWithHttpInfo ()
        {

            var localVarPath = "/api/v2/recording/recordingkeys";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingkeys: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingkeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKey)));
            
        }

        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of EncryptionKey</returns>
        public async System.Threading.Tasks.Task<EncryptionKey> PostRecordingkeysAsync ()
        {
             ApiResponse<EncryptionKey> localVarResponse = await PostRecordingkeysAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create encryption key 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (EncryptionKey)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<EncryptionKey>> PostRecordingkeysAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v2/recording/recordingkeys";
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
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingkeys: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PostRecordingkeys: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<EncryptionKey>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (EncryptionKey) Configuration.ApiClient.Deserialize(localVarResponse, typeof(EncryptionKey)));
            
        }

        /// <summary>
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <returns>Recording</returns>
        public Recording PutConversationIdRecordingsRecordingId (string conversationId, string recordingId, Recording body)
        {
             ApiResponse<Recording> localVarResponse = PutConversationIdRecordingsRecordingIdWithHttpInfo(conversationId, recordingId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <returns>ApiResponse of Recording</returns>
        public ApiResponse< Recording > PutConversationIdRecordingsRecordingIdWithHttpInfo (string conversationId, string recordingId, Recording body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->PutConversationIdRecordingsRecordingId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->PutConversationIdRecordingsRecordingId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutConversationIdRecordingsRecordingId");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutConversationIdRecordingsRecordingId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutConversationIdRecordingsRecordingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recording)));
            
        }

        /// <summary>
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <returns>Task of Recording</returns>
        public async System.Threading.Tasks.Task<Recording> PutConversationIdRecordingsRecordingIdAsync (string conversationId, string recordingId, Recording body)
        {
             ApiResponse<Recording> localVarResponse = await PutConversationIdRecordingsRecordingIdAsyncWithHttpInfo(conversationId, recordingId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates the retention records on a recording. Currently supports updating and removing both archive and delete dates for eligible recordings. A request to change the archival date of an archived recording will result in a restoration of the recording until the new date set. 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="body">recording</param>
        /// <returns>Task of ApiResponse (Recording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recording>> PutConversationIdRecordingsRecordingIdAsyncWithHttpInfo (string conversationId, string recordingId, Recording body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->PutConversationIdRecordingsRecordingId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->PutConversationIdRecordingsRecordingId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutConversationIdRecordingsRecordingId");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutConversationIdRecordingsRecordingId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutConversationIdRecordingsRecordingId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recording)));
            
        }

        /// <summary>
        /// Update annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Annotation</returns>
        public Annotation PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId (string conversationId, string recordingId, string annotationId, Annotation body)
        {
             ApiResponse<Annotation> localVarResponse = PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo(conversationId, recordingId, annotationId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>ApiResponse of Annotation</returns>
        public ApiResponse< Annotation > PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling RecordingApi->PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

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
        /// <param name="body">annotation</param>
        /// <returns>Task of Annotation</returns>
        public async System.Threading.Tasks.Task<Annotation> PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsync (string conversationId, string recordingId, string annotationId, Annotation body)
        {
             ApiResponse<Annotation> localVarResponse = await PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo(conversationId, recordingId, annotationId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update annotation 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="conversationId">Conversation ID</param>
        /// <param name="recordingId">Recording ID</param>
        /// <param name="annotationId">Annotation ID</param>
        /// <param name="body">annotation</param>
        /// <returns>Task of ApiResponse (Annotation)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Annotation>> PutConversationIdRecordingsRecordingIdAnnotationsAnnotationIdAsyncWithHttpInfo (string conversationId, string recordingId, string annotationId, Annotation body)
        {
            // verify the required parameter 'conversationId' is set
            if (conversationId == null)
                throw new ApiException(400, "Missing required parameter 'conversationId' when calling RecordingApi->PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'recordingId' is set
            if (recordingId == null)
                throw new ApiException(400, "Missing required parameter 'recordingId' when calling RecordingApi->PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'annotationId' is set
            if (annotationId == null)
                throw new ApiException(400, "Missing required parameter 'annotationId' when calling RecordingApi->PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId");

            var localVarPath = "/api/v2/conversations/{conversationId}/recordings/{recordingId}/annotations/{annotationId}";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutConversationIdRecordingsRecordingIdAnnotationsAnnotationId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Annotation>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Annotation) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Annotation)));
            
        }

        /// <summary>
        /// Update the local encryption settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <param name="body">Local Encryption metadata</param>
        /// <returns>LocalEncryptionConfiguration</returns>
        public LocalEncryptionConfiguration PutLocalkeysSettingsSettingsId (string settingsId, LocalEncryptionConfiguration body)
        {
             ApiResponse<LocalEncryptionConfiguration> localVarResponse = PutLocalkeysSettingsSettingsIdWithHttpInfo(settingsId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the local encryption settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <param name="body">Local Encryption metadata</param>
        /// <returns>ApiResponse of LocalEncryptionConfiguration</returns>
        public ApiResponse< LocalEncryptionConfiguration > PutLocalkeysSettingsSettingsIdWithHttpInfo (string settingsId, LocalEncryptionConfiguration body)
        {
            // verify the required parameter 'settingsId' is set
            if (settingsId == null)
                throw new ApiException(400, "Missing required parameter 'settingsId' when calling RecordingApi->PutLocalkeysSettingsSettingsId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutLocalkeysSettingsSettingsId");

            var localVarPath = "/api/v2/recording/localkeys/settings/{settingsId}";
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
            if (settingsId != null) localVarPathParams.Add("settingsId", Configuration.ApiClient.ParameterToString(settingsId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutLocalkeysSettingsSettingsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutLocalkeysSettingsSettingsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocalEncryptionConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocalEncryptionConfiguration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocalEncryptionConfiguration)));
            
        }

        /// <summary>
        /// Update the local encryption settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <param name="body">Local Encryption metadata</param>
        /// <returns>Task of LocalEncryptionConfiguration</returns>
        public async System.Threading.Tasks.Task<LocalEncryptionConfiguration> PutLocalkeysSettingsSettingsIdAsync (string settingsId, LocalEncryptionConfiguration body)
        {
             ApiResponse<LocalEncryptionConfiguration> localVarResponse = await PutLocalkeysSettingsSettingsIdAsyncWithHttpInfo(settingsId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the local encryption settings 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="settingsId">Settings Id</param>
        /// <param name="body">Local Encryption metadata</param>
        /// <returns>Task of ApiResponse (LocalEncryptionConfiguration)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<LocalEncryptionConfiguration>> PutLocalkeysSettingsSettingsIdAsyncWithHttpInfo (string settingsId, LocalEncryptionConfiguration body)
        {
            // verify the required parameter 'settingsId' is set
            if (settingsId == null)
                throw new ApiException(400, "Missing required parameter 'settingsId' when calling RecordingApi->PutLocalkeysSettingsSettingsId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutLocalkeysSettingsSettingsId");

            var localVarPath = "/api/v2/recording/localkeys/settings/{settingsId}";
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
            if (settingsId != null) localVarPathParams.Add("settingsId", Configuration.ApiClient.ParameterToString(settingsId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutLocalkeysSettingsSettingsId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutLocalkeysSettingsSettingsId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<LocalEncryptionConfiguration>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (LocalEncryptionConfiguration) Configuration.ApiClient.Deserialize(localVarResponse, typeof(LocalEncryptionConfiguration)));
            
        }

        /// <summary>
        /// Update a media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Policy</returns>
        public Policy PutMediaretentionpoliciesPolicyId (string policyId, Policy body)
        {
             ApiResponse<Policy> localVarResponse = PutMediaretentionpoliciesPolicyIdWithHttpInfo(policyId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>ApiResponse of Policy</returns>
        public ApiResponse< Policy > PutMediaretentionpoliciesPolicyIdWithHttpInfo (string policyId, Policy body)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->PutMediaretentionpoliciesPolicyId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutMediaretentionpoliciesPolicyId");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutMediaretentionpoliciesPolicyId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutMediaretentionpoliciesPolicyId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        /// <summary>
        /// Update a media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of Policy</returns>
        public async System.Threading.Tasks.Task<Policy> PutMediaretentionpoliciesPolicyIdAsync (string policyId, Policy body)
        {
             ApiResponse<Policy> localVarResponse = await PutMediaretentionpoliciesPolicyIdAsyncWithHttpInfo(policyId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a media retention policy 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="policyId">Policy ID</param>
        /// <param name="body">Policy</param>
        /// <returns>Task of ApiResponse (Policy)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Policy>> PutMediaretentionpoliciesPolicyIdAsyncWithHttpInfo (string policyId, Policy body)
        {
            // verify the required parameter 'policyId' is set
            if (policyId == null)
                throw new ApiException(400, "Missing required parameter 'policyId' when calling RecordingApi->PutMediaretentionpoliciesPolicyId");
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutMediaretentionpoliciesPolicyId");

            var localVarPath = "/api/v2/recording/mediaretentionpolicies/{policyId}";
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
            if (policyId != null) localVarPathParams.Add("policyId", Configuration.ApiClient.ParameterToString(policyId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutMediaretentionpoliciesPolicyId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutMediaretentionpoliciesPolicyId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Policy>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Policy) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Policy)));
            
        }

        /// <summary>
        /// Updates an orphan recording to a regular recording with retention values If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Recording</returns>
        public Recording PutOrphanId (string orphanId, OrphanUpdateRequest body = null)
        {
             ApiResponse<Recording> localVarResponse = PutOrphanIdWithHttpInfo(orphanId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Updates an orphan recording to a regular recording with retention values If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of Recording</returns>
        public ApiResponse< Recording > PutOrphanIdWithHttpInfo (string orphanId, OrphanUpdateRequest body = null)
        {
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling RecordingApi->PutOrphanId");

            var localVarPath = "/api/v2/orphanrecordings/{orphanId}";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", Configuration.ApiClient.ParameterToString(orphanId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutOrphanId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOrphanId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recording)));
            
        }

        /// <summary>
        /// Updates an orphan recording to a regular recording with retention values If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of Recording</returns>
        public async System.Threading.Tasks.Task<Recording> PutOrphanIdAsync (string orphanId, OrphanUpdateRequest body = null)
        {
             ApiResponse<Recording> localVarResponse = await PutOrphanIdAsyncWithHttpInfo(orphanId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Updates an orphan recording to a regular recording with retention values If this operation is successful the orphan will no longer exist. It will be replaced by the resulting recording in the response. This replacement recording is accessible by the normal Recording api.
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="orphanId">Orphan ID</param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (Recording)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Recording>> PutOrphanIdAsyncWithHttpInfo (string orphanId, OrphanUpdateRequest body = null)
        {
            // verify the required parameter 'orphanId' is set
            if (orphanId == null)
                throw new ApiException(400, "Missing required parameter 'orphanId' when calling RecordingApi->PutOrphanId");

            var localVarPath = "/api/v2/orphanrecordings/{orphanId}";
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
            if (orphanId != null) localVarPathParams.Add("orphanId", Configuration.ApiClient.ParameterToString(orphanId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutOrphanId: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutOrphanId: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<Recording>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Recording) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Recording)));
            
        }

        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>KeyRotationSchedule</returns>
        public KeyRotationSchedule PutRecordingkeysRotationschedule (KeyRotationSchedule body)
        {
             ApiResponse<KeyRotationSchedule> localVarResponse = PutRecordingkeysRotationscheduleWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>ApiResponse of KeyRotationSchedule</returns>
        public ApiResponse< KeyRotationSchedule > PutRecordingkeysRotationscheduleWithHttpInfo (KeyRotationSchedule body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutRecordingkeysRotationschedule");

            var localVarPath = "/api/v2/recording/recordingkeys/rotationschedule";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingkeysRotationschedule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingkeysRotationschedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeyRotationSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeyRotationSchedule)));
            
        }

        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of KeyRotationSchedule</returns>
        public async System.Threading.Tasks.Task<KeyRotationSchedule> PutRecordingkeysRotationscheduleAsync (KeyRotationSchedule body)
        {
             ApiResponse<KeyRotationSchedule> localVarResponse = await PutRecordingkeysRotationscheduleAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update key rotation schedule 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">KeyRotationSchedule</param>
        /// <returns>Task of ApiResponse (KeyRotationSchedule)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<KeyRotationSchedule>> PutRecordingkeysRotationscheduleAsyncWithHttpInfo (KeyRotationSchedule body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutRecordingkeysRotationschedule");

            var localVarPath = "/api/v2/recording/recordingkeys/rotationschedule";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingkeysRotationschedule: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutRecordingkeysRotationschedule: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<KeyRotationSchedule>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (KeyRotationSchedule) Configuration.ApiClient.Deserialize(localVarResponse, typeof(KeyRotationSchedule)));
            
        }

        /// <summary>
        /// Update the Recording Settings for the Organization 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Recording settings</param>
        /// <returns>RecordingSettings</returns>
        public RecordingSettings PutSettings (RecordingSettings body)
        {
             ApiResponse<RecordingSettings> localVarResponse = PutSettingsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update the Recording Settings for the Organization 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Recording settings</param>
        /// <returns>ApiResponse of RecordingSettings</returns>
        public ApiResponse< RecordingSettings > PutSettingsWithHttpInfo (RecordingSettings body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutSettings");

            var localVarPath = "/api/v2/recording/settings";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RecordingSettings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingSettings)));
            
        }

        /// <summary>
        /// Update the Recording Settings for the Organization 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Recording settings</param>
        /// <returns>Task of RecordingSettings</returns>
        public async System.Threading.Tasks.Task<RecordingSettings> PutSettingsAsync (RecordingSettings body)
        {
             ApiResponse<RecordingSettings> localVarResponse = await PutSettingsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update the Recording Settings for the Organization 
        /// </summary>
        /// <exception cref="ININ.PureCloudApi.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">Recording settings</param>
        /// <returns>Task of ApiResponse (RecordingSettings)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RecordingSettings>> PutSettingsAsyncWithHttpInfo (RecordingSettings body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling RecordingApi->PutSettings");

            var localVarPath = "/api/v2/recording/settings";
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
            if (body != null && body.GetType() != typeof(byte[]))
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
                throw new ApiException (localVarStatusCode, "Error calling PutSettings: " + localVarResponse.Content, localVarResponse.Content);
            else if (localVarStatusCode == 0)
                throw new ApiException (localVarStatusCode, "Error calling PutSettings: " + localVarResponse.ErrorMessage, localVarResponse.ErrorMessage);

            return new ApiResponse<RecordingSettings>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RecordingSettings) Configuration.ApiClient.Deserialize(localVarResponse, typeof(RecordingSettings)));
            
        }

    }
}
