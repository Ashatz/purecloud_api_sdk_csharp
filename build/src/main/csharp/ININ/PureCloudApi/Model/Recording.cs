using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;



namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public class Recording :  IEquatable<Recording>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Recording" /> class.
        /// </summary>
        public Recording()
        {
            
        }

        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
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
        /// Gets or Sets Media
        /// </summary>
        [DataMember(Name="media", EmitDefaultValue=false)]
        public string Media { get; set; }
  
        
        /// <summary>
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
        /// </summary>
        [DataMember(Name="annotations", EmitDefaultValue=false)]
        public List<Annotation> Annotations { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Transcript
        /// </summary>
        [DataMember(Name="transcript", EmitDefaultValue=false)]
        public List<ChatMessage> Transcript { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EmailTranscript
        /// </summary>
        [DataMember(Name="emailTranscript", EmitDefaultValue=false)]
        public List<EmailMessage> EmailTranscript { get; set; }
  
        
        /// <summary>
        /// Gets or Sets FileState
        /// </summary>
        [DataMember(Name="fileState", EmitDefaultValue=false)]
        public string FileState { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="restoreExpirationTime", EmitDefaultValue=false)]
        public DateTime? RestoreExpirationTime { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MediaUris
        /// </summary>
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
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="archiveDate", EmitDefaultValue=false)]
        public DateTime? ArchiveDate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ArchiveMedium
        /// </summary>
        [DataMember(Name="archiveMedium", EmitDefaultValue=false)]
        public string ArchiveMedium { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="deleteDate", EmitDefaultValue=false)]
        public DateTime? DeleteDate { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MaxAllowedRestorationsForOrg
        /// </summary>
        [DataMember(Name="maxAllowedRestorationsForOrg", EmitDefaultValue=false)]
        public int? MaxAllowedRestorationsForOrg { get; set; }
  
        
        /// <summary>
        /// Gets or Sets RemainingRestorationsAllowedForOrg
        /// </summary>
        [DataMember(Name="remainingRestorationsAllowedForOrg", EmitDefaultValue=false)]
        public int? RemainingRestorationsAllowedForOrg { get; set; }
  
        
        /// <summary>
        /// Gets or Sets RecordingId
        /// </summary>
        [DataMember(Name="recordingId", EmitDefaultValue=false)]
        public string RecordingId { get; set; }
  
        
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; set; }
  
        
  
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
            sb.Append("  MediaUri: ").Append(MediaUri).Append("\n");
            sb.Append("  WaveUri: ").Append(WaveUri).Append("\n");
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
            sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
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
        /// <param name="obj">Instance of Recording to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Recording other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.RecordingId == other.RecordingId ||
                    this.RecordingId != null &&
                    this.RecordingId.Equals(other.RecordingId)
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
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.ConversationId != null)
                    hash = hash * 57 + this.ConversationId.GetHashCode();
                
                if (this.Path != null)
                    hash = hash * 57 + this.Path.GetHashCode();
                
                if (this.StartTime != null)
                    hash = hash * 57 + this.StartTime.GetHashCode();
                
                if (this.EndTime != null)
                    hash = hash * 57 + this.EndTime.GetHashCode();
                
                if (this.Media != null)
                    hash = hash * 57 + this.Media.GetHashCode();
                
                if (this.MediaUri != null)
                    hash = hash * 57 + this.MediaUri.GetHashCode();
                
                if (this.WaveUri != null)
                    hash = hash * 57 + this.WaveUri.GetHashCode();
                
                if (this.Annotations != null)
                    hash = hash * 57 + this.Annotations.GetHashCode();
                
                if (this.Transcript != null)
                    hash = hash * 57 + this.Transcript.GetHashCode();
                
                if (this.EmailTranscript != null)
                    hash = hash * 57 + this.EmailTranscript.GetHashCode();
                
                if (this.FileState != null)
                    hash = hash * 57 + this.FileState.GetHashCode();
                
                if (this.RestoreExpirationTime != null)
                    hash = hash * 57 + this.RestoreExpirationTime.GetHashCode();
                
                if (this.MediaUris != null)
                    hash = hash * 57 + this.MediaUris.GetHashCode();
                
                if (this.EstimatedTranscodeTimeMs != null)
                    hash = hash * 57 + this.EstimatedTranscodeTimeMs.GetHashCode();
                
                if (this.ActualTranscodeTimeMs != null)
                    hash = hash * 57 + this.ActualTranscodeTimeMs.GetHashCode();
                
                if (this.ArchiveDate != null)
                    hash = hash * 57 + this.ArchiveDate.GetHashCode();
                
                if (this.ArchiveMedium != null)
                    hash = hash * 57 + this.ArchiveMedium.GetHashCode();
                
                if (this.DeleteDate != null)
                    hash = hash * 57 + this.DeleteDate.GetHashCode();
                
                if (this.MaxAllowedRestorationsForOrg != null)
                    hash = hash * 57 + this.MaxAllowedRestorationsForOrg.GetHashCode();
                
                if (this.RemainingRestorationsAllowedForOrg != null)
                    hash = hash * 57 + this.RemainingRestorationsAllowedForOrg.GetHashCode();
                
                if (this.RecordingId != null)
                    hash = hash * 57 + this.RecordingId.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
