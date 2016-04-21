using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ININ.PureCloudApi.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class Recording :  IEquatable<Recording>
    { 

        /// <summary>
<<<<<<< HEAD
        /// Gets or Sets FileState
        /// </summary>
=======
        /// Represents the current file state for a recording. Examples: Uploading, Archived, etc
        /// </summary>
        /// <value>Represents the current file state for a recording. Examples: Uploading, Archived, etc</value>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        [JsonConverter(typeof(StringEnumConverter))]
                public enum FileStateEnum {
            
            [EnumMember(Value = "ARCHIVED")]
            Archived,
            
            [EnumMember(Value = "AVAILABLE")]
            Available,
            
            [EnumMember(Value = "DELETED")]
            Deleted,
            
            [EnumMember(Value = "RESTORED")]
            Restored,
<<<<<<< HEAD
            
            [EnumMember(Value = "RESTORING")]
            Restoring,
            
            [EnumMember(Value = "UPLOADING")]
            Uploading
        }


        /// <summary>
        /// Gets or Sets ArchiveMedium
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ArchiveMediumEnum {
            
=======
            
            [EnumMember(Value = "RESTORING")]
            Restoring,
            
            [EnumMember(Value = "UPLOADING")]
            Uploading
        }


        /// <summary>
        /// The type of archive medium used. Example: CloudArchive
        /// </summary>
        /// <value>The type of archive medium used. Example: CloudArchive</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ArchiveMediumEnum {
            
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            [EnumMember(Value = "CLOUDARCHIVE")]
            Cloudarchive
        }

        

        /// <summary>
        /// Gets or Sets FileState
        /// </summary>
        [DataMember(Name="fileState", EmitDefaultValue=false)]
        public FileStateEnum? FileState { get; set; }
    

        /// <summary>
        /// Gets or Sets ArchiveMedium
        /// </summary>
        [DataMember(Name="archiveMedium", EmitDefaultValue=false)]
        public ArchiveMediumEnum? ArchiveMedium { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Recording" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="Path">Path.</param>
        /// <param name="StartTime">StartTime.</param>
        /// <param name="EndTime">EndTime.</param>
        /// <param name="Media">Media.</param>
        /// <param name="MediaUri">MediaUri.</param>
        /// <param name="WaveUri">WaveUri.</param>
        /// <param name="Annotations">Annotations.</param>
        /// <param name="Transcript">Transcript.</param>
        /// <param name="EmailTranscript">EmailTranscript.</param>
        /// <param name="FileState">FileState.</param>
        /// <param name="RestoreExpirationTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="MediaUris">MediaUris.</param>
        /// <param name="EstimatedTranscodeTimeMs">EstimatedTranscodeTimeMs.</param>
        /// <param name="ActualTranscodeTimeMs">ActualTranscodeTimeMs.</param>
        /// <param name="ArchiveDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ArchiveMedium">ArchiveMedium.</param>
        /// <param name="DeleteDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="MaxAllowedRestorationsForOrg">MaxAllowedRestorationsForOrg.</param>
        /// <param name="RemainingRestorationsAllowedForOrg">RemainingRestorationsAllowedForOrg.</param>
        /// <param name="RecordingId">RecordingId.</param>

        public Recording(string Name = null, string ConversationId = null, string Path = null, string StartTime = null, string EndTime = null, string Media = null, string MediaUri = null, string WaveUri = null, List<Annotation> Annotations = null, List<ChatMessage> Transcript = null, List<EmailMessage> EmailTranscript = null, FileStateEnum? FileState = null, DateTime? RestoreExpirationTime = null, Dictionary<string, MediaResult> MediaUris = null, long? EstimatedTranscodeTimeMs = null, long? ActualTranscodeTimeMs = null, DateTime? ArchiveDate = null, ArchiveMediumEnum? ArchiveMedium = null, DateTime? DeleteDate = null, int? MaxAllowedRestorationsForOrg = null, int? RemainingRestorationsAllowedForOrg = null, string RecordingId = null)
        {
            this.Name = Name;
            this.ConversationId = ConversationId;
            this.Path = Path;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.Media = Media;
            this.MediaUri = MediaUri;
            this.WaveUri = WaveUri;
            this.Annotations = Annotations;
            this.Transcript = Transcript;
            this.EmailTranscript = EmailTranscript;
            this.FileState = FileState;
            this.RestoreExpirationTime = RestoreExpirationTime;
            this.MediaUris = MediaUris;
            this.EstimatedTranscodeTimeMs = EstimatedTranscodeTimeMs;
            this.ActualTranscodeTimeMs = ActualTranscodeTimeMs;
            this.ArchiveDate = ArchiveDate;
            this.ArchiveMedium = ArchiveMedium;
            this.DeleteDate = DeleteDate;
            this.MaxAllowedRestorationsForOrg = MaxAllowedRestorationsForOrg;
            this.RemainingRestorationsAllowedForOrg = RemainingRestorationsAllowedForOrg;
            this.RecordingId = RecordingId;
            
        }

    
        /// <summary>
        /// Represents the current file state for a recording. Examples: Uploading, Archived, etc
        /// </summary>
        /// <value>Represents the current file state for a recording. Examples: Uploading, Archived, etc</value>
        [DataMember(Name="fileState", EmitDefaultValue=false)]
        public FileStateEnum? FileState { get; set; }
    
        /// <summary>
        /// The type of archive medium used. Example: CloudArchive
        /// </summary>
        /// <value>The type of archive medium used. Example: CloudArchive</value>
        [DataMember(Name="archiveMedium", EmitDefaultValue=false)]
        public ArchiveMediumEnum? ArchiveMedium { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Recording" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ConversationId">ConversationId.</param>
        /// <param name="Path">Path.</param>
        /// <param name="StartTime">StartTime.</param>
        /// <param name="EndTime">EndTime.</param>
        /// <param name="Media">The type of media that the recording is..</param>
        /// <param name="Annotations">Annotations that belong to the recording..</param>
        /// <param name="Transcript">Represents a chat transcript.</param>
        /// <param name="EmailTranscript">Represents an email transcript.</param>
        /// <param name="FileState">Represents the current file state for a recording. Examples: Uploading, Archived, etc.</param>
        /// <param name="RestoreExpirationTime">The amount of time a restored recording will remain restored before being archived again. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="MediaUris">The different mediaUris for the recording..</param>
        /// <param name="EstimatedTranscodeTimeMs">EstimatedTranscodeTimeMs.</param>
        /// <param name="ActualTranscodeTimeMs">ActualTranscodeTimeMs.</param>
        /// <param name="ArchiveDate">The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ArchiveMedium">The type of archive medium used. Example: CloudArchive.</param>
        /// <param name="DeleteDate">The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="MaxAllowedRestorationsForOrg">How many archive restorations the organization is allowed to have..</param>
        /// <param name="RemainingRestorationsAllowedForOrg">The remaining archive restorations the organization has..</param>
        /// <param name="SessionId">The session id represents an external resource id, such as email, call, chat, etc.</param>

        public Recording(string Name = null, string ConversationId = null, string Path = null, string StartTime = null, string EndTime = null, string Media = null, List<Annotation> Annotations = null, List<ChatMessage> Transcript = null, List<RecordingEmailMessage> EmailTranscript = null, FileStateEnum? FileState = null, DateTime? RestoreExpirationTime = null, Dictionary<string, MediaResult> MediaUris = null, long? EstimatedTranscodeTimeMs = null, long? ActualTranscodeTimeMs = null, DateTime? ArchiveDate = null, ArchiveMediumEnum? ArchiveMedium = null, DateTime? DeleteDate = null, int? MaxAllowedRestorationsForOrg = null, int? RemainingRestorationsAllowedForOrg = null, string SessionId = null)
        {
            this.Name = Name;
            this.ConversationId = ConversationId;
            this.Path = Path;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.Media = Media;
            this.Annotations = Annotations;
            this.Transcript = Transcript;
            this.EmailTranscript = EmailTranscript;
            this.FileState = FileState;
            this.RestoreExpirationTime = RestoreExpirationTime;
            this.MediaUris = MediaUris;
            this.EstimatedTranscodeTimeMs = EstimatedTranscodeTimeMs;
            this.ActualTranscodeTimeMs = ActualTranscodeTimeMs;
            this.ArchiveDate = ArchiveDate;
            this.ArchiveMedium = ArchiveMedium;
            this.DeleteDate = DeleteDate;
            this.MaxAllowedRestorationsForOrg = MaxAllowedRestorationsForOrg;
            this.RemainingRestorationsAllowedForOrg = RemainingRestorationsAllowedForOrg;
            this.SessionId = SessionId;
            
        }

    
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
    
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or Sets ConversationId
        /// </summary>
        [DataMember(Name="conversationId", EmitDefaultValue=false)]
        public string ConversationId { get; set; }
    
        /// <summary>
        /// Gets or Sets Path
        /// </summary>
        [DataMember(Name="path", EmitDefaultValue=false)]
        public string Path { get; set; }
    
        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public string StartTime { get; set; }
    
        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public string EndTime { get; set; }
    
        /// <summary>
        /// The type of media that the recording is.
        /// </summary>
        /// <value>The type of media that the recording is.</value>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public string Media { get; set; }
    
        /// <summary>
<<<<<<< HEAD
        /// Gets or Sets MediaUri
        /// </summary>
        [DataMember(Name="mediaUri", EmitDefaultValue=false)]
        public string MediaUri { get; set; }
    
        /// <summary>
        /// Gets or Sets WaveUri
        /// </summary>
        [DataMember(Name="waveUri", EmitDefaultValue=false)]
        public string WaveUri { get; set; }
    
        /// <summary>
        /// Gets or Sets Annotations
=======
        /// Annotations that belong to the recording.
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// </summary>
        /// <value>Annotations that belong to the recording.</value>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        public List<Annotation> Annotations { get; set; }
    
        /// <summary>
        /// Represents a chat transcript
        /// </summary>
        /// <value>Represents a chat transcript</value>
        [DataMember(Name="transcript", EmitDefaultValue=false)]
        public List<ChatMessage> Transcript { get; set; }
    
        /// <summary>
        /// Represents an email transcript
        /// </summary>
        /// <value>Represents an email transcript</value>
        [DataMember(Name="emailTranscript", EmitDefaultValue=false)]
<<<<<<< HEAD
        public List<EmailMessage> EmailTranscript { get; set; }
=======
        public List<RecordingEmailMessage> EmailTranscript { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// The amount of time a restored recording will remain restored before being archived again. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The amount of time a restored recording will remain restored before being archived again. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="restoreExpirationTime", EmitDefaultValue=false)]
        public DateTime? RestoreExpirationTime { get; set; }
    
        /// <summary>
        /// The different mediaUris for the recording.
        /// </summary>
        /// <value>The different mediaUris for the recording.</value>
        [DataMember(Name="mediaUris", EmitDefaultValue=false)]
        public Dictionary<string, MediaResult> MediaUris { get; set; }
    
        /// <summary>
        /// Gets or Sets EstimatedTranscodeTimeMs
        /// </summary>
        [DataMember(Name="estimatedTranscodeTimeMs", EmitDefaultValue=false)]
        public long? EstimatedTranscodeTimeMs { get; set; }
    
        /// <summary>
        /// Gets or Sets ActualTranscodeTimeMs
        /// </summary>
        [DataMember(Name="actualTranscodeTimeMs", EmitDefaultValue=false)]
        public long? ActualTranscodeTimeMs { get; set; }
    
        /// <summary>
        /// The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="archiveDate", EmitDefaultValue=false)]
        public DateTime? ArchiveDate { get; set; }
    
        /// <summary>
<<<<<<< HEAD
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
=======
        /// The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        [DataMember(Name="deleteDate", EmitDefaultValue=false)]
        public DateTime? DeleteDate { get; set; }
    
        /// <summary>
        /// How many archive restorations the organization is allowed to have.
        /// </summary>
        /// <value>How many archive restorations the organization is allowed to have.</value>
        [DataMember(Name="maxAllowedRestorationsForOrg", EmitDefaultValue=false)]
        public int? MaxAllowedRestorationsForOrg { get; set; }
    
        /// <summary>
        /// The remaining archive restorations the organization has.
        /// </summary>
        /// <value>The remaining archive restorations the organization has.</value>
        [DataMember(Name="remainingRestorationsAllowedForOrg", EmitDefaultValue=false)]
        public int? RemainingRestorationsAllowedForOrg { get; set; }
    
        /// <summary>
        /// The session id represents an external resource id, such as email, call, chat, etc
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="recordingId", EmitDefaultValue=false)]
        public string RecordingId { get; set; }
=======
        /// <value>The session id represents an external resource id, such as email, call, chat, etc</value>
        [DataMember(Name="sessionId", EmitDefaultValue=false)]
        public string SessionId { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Recording {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Media: ").Append(Media).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Transcript: ").Append(Transcript).Append("\n");
            sb.Append("  EmailTranscript: ").Append(EmailTranscript).Append("\n");
            sb.Append("  FileState: ").Append(FileState).Append("\n");
            sb.Append("  RestoreExpirationTime: ").Append(RestoreExpirationTime).Append("\n");
            sb.Append("  MediaUris: ").Append(MediaUris).Append("\n");
            sb.Append("  EstimatedTranscodeTimeMs: ").Append(EstimatedTranscodeTimeMs).Append("\n");
            sb.Append("  ActualTranscodeTimeMs: ").Append(ActualTranscodeTimeMs).Append("\n");
            sb.Append("  ArchiveDate: ").Append(ArchiveDate).Append("\n");
            sb.Append("  ArchiveMedium: ").Append(ArchiveMedium).Append("\n");
            sb.Append("  DeleteDate: ").Append(DeleteDate).Append("\n");
            sb.Append("  MaxAllowedRestorationsForOrg: ").Append(MaxAllowedRestorationsForOrg).Append("\n");
            sb.Append("  RemainingRestorationsAllowedForOrg: ").Append(RemainingRestorationsAllowedForOrg).Append("\n");
            sb.Append("  SessionId: ").Append(SessionId).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as Recording);
        }

        /// <summary>
        /// Returns true if Recording instances are equal
        /// </summary>
        /// <param name="other">Instance of Recording to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Recording other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.ConversationId == other.ConversationId ||
                    this.ConversationId != null &&
                    this.ConversationId.Equals(other.ConversationId)
                ) &&
                (
                    this.Path == other.Path ||
                    this.Path != null &&
                    this.Path.Equals(other.Path)
                ) &&
                (
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) &&
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) &&
                (
                    this.Media == other.Media ||
                    this.Media != null &&
                    this.Media.Equals(other.Media)
                ) &&
<<<<<<< HEAD
                (
                    this.MediaUri == other.MediaUri ||
                    this.MediaUri != null &&
                    this.MediaUri.Equals(other.MediaUri)
                ) &&
                (
                    this.WaveUri == other.WaveUri ||
                    this.WaveUri != null &&
                    this.WaveUri.Equals(other.WaveUri)
                ) &&
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                (
                    this.Annotations == other.Annotations ||
                    this.Annotations != null &&
                    this.Annotations.SequenceEqual(other.Annotations)
                ) &&
                (
                    this.Transcript == other.Transcript ||
                    this.Transcript != null &&
                    this.Transcript.SequenceEqual(other.Transcript)
                ) &&
                (
                    this.EmailTranscript == other.EmailTranscript ||
                    this.EmailTranscript != null &&
                    this.EmailTranscript.SequenceEqual(other.EmailTranscript)
                ) &&
                (
                    this.FileState == other.FileState ||
                    this.FileState != null &&
                    this.FileState.Equals(other.FileState)
                ) &&
                (
                    this.RestoreExpirationTime == other.RestoreExpirationTime ||
                    this.RestoreExpirationTime != null &&
                    this.RestoreExpirationTime.Equals(other.RestoreExpirationTime)
                ) &&
                (
                    this.MediaUris == other.MediaUris ||
                    this.MediaUris != null &&
                    this.MediaUris.SequenceEqual(other.MediaUris)
                ) &&
                (
                    this.EstimatedTranscodeTimeMs == other.EstimatedTranscodeTimeMs ||
                    this.EstimatedTranscodeTimeMs != null &&
                    this.EstimatedTranscodeTimeMs.Equals(other.EstimatedTranscodeTimeMs)
                ) &&
                (
                    this.ActualTranscodeTimeMs == other.ActualTranscodeTimeMs ||
                    this.ActualTranscodeTimeMs != null &&
                    this.ActualTranscodeTimeMs.Equals(other.ActualTranscodeTimeMs)
                ) &&
                (
                    this.ArchiveDate == other.ArchiveDate ||
                    this.ArchiveDate != null &&
                    this.ArchiveDate.Equals(other.ArchiveDate)
                ) &&
                (
                    this.ArchiveMedium == other.ArchiveMedium ||
                    this.ArchiveMedium != null &&
                    this.ArchiveMedium.Equals(other.ArchiveMedium)
                ) &&
                (
                    this.DeleteDate == other.DeleteDate ||
                    this.DeleteDate != null &&
                    this.DeleteDate.Equals(other.DeleteDate)
                ) &&
                (
                    this.MaxAllowedRestorationsForOrg == other.MaxAllowedRestorationsForOrg ||
                    this.MaxAllowedRestorationsForOrg != null &&
                    this.MaxAllowedRestorationsForOrg.Equals(other.MaxAllowedRestorationsForOrg)
                ) &&
                (
                    this.RemainingRestorationsAllowedForOrg == other.RemainingRestorationsAllowedForOrg ||
                    this.RemainingRestorationsAllowedForOrg != null &&
                    this.RemainingRestorationsAllowedForOrg.Equals(other.RemainingRestorationsAllowedForOrg)
                ) &&
                (
<<<<<<< HEAD
                    this.RecordingId == other.RecordingId ||
                    this.RecordingId != null &&
                    this.RecordingId.Equals(other.RecordingId)
=======
                    this.SessionId == other.SessionId ||
                    this.SessionId != null &&
                    this.SessionId.Equals(other.SessionId)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ConversationId != null)
                    hash = hash * 59 + this.ConversationId.GetHashCode();
                if (this.Path != null)
                    hash = hash * 59 + this.Path.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
                if (this.Media != null)
                    hash = hash * 59 + this.Media.GetHashCode();
<<<<<<< HEAD
                if (this.MediaUri != null)
                    hash = hash * 59 + this.MediaUri.GetHashCode();
                if (this.WaveUri != null)
                    hash = hash * 59 + this.WaveUri.GetHashCode();
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                if (this.Annotations != null)
                    hash = hash * 59 + this.Annotations.GetHashCode();
                if (this.Transcript != null)
                    hash = hash * 59 + this.Transcript.GetHashCode();
                if (this.EmailTranscript != null)
                    hash = hash * 59 + this.EmailTranscript.GetHashCode();
                if (this.FileState != null)
                    hash = hash * 59 + this.FileState.GetHashCode();
                if (this.RestoreExpirationTime != null)
                    hash = hash * 59 + this.RestoreExpirationTime.GetHashCode();
                if (this.MediaUris != null)
                    hash = hash * 59 + this.MediaUris.GetHashCode();
                if (this.EstimatedTranscodeTimeMs != null)
                    hash = hash * 59 + this.EstimatedTranscodeTimeMs.GetHashCode();
                if (this.ActualTranscodeTimeMs != null)
                    hash = hash * 59 + this.ActualTranscodeTimeMs.GetHashCode();
                if (this.ArchiveDate != null)
                    hash = hash * 59 + this.ArchiveDate.GetHashCode();
                if (this.ArchiveMedium != null)
                    hash = hash * 59 + this.ArchiveMedium.GetHashCode();
                if (this.DeleteDate != null)
                    hash = hash * 59 + this.DeleteDate.GetHashCode();
                if (this.MaxAllowedRestorationsForOrg != null)
                    hash = hash * 59 + this.MaxAllowedRestorationsForOrg.GetHashCode();
                if (this.RemainingRestorationsAllowedForOrg != null)
                    hash = hash * 59 + this.RemainingRestorationsAllowedForOrg.GetHashCode();
<<<<<<< HEAD
                if (this.RecordingId != null)
                    hash = hash * 59 + this.RecordingId.GetHashCode();
=======
                if (this.SessionId != null)
                    hash = hash * 59 + this.SessionId.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
