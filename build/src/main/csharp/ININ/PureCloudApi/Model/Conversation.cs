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
    public class Conversation :  IEquatable<Conversation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation" /> class.
        /// </summary>
        public Conversation()
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
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Participants
        /// </summary>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<Participant> Participants { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ConversationIds
        /// </summary>
        [DataMember(Name="conversationIds", EmitDefaultValue=false)]
        public List<string> ConversationIds { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MaxParticipants
        /// </summary>
        [DataMember(Name="maxParticipants", EmitDefaultValue=false)]
        public int? MaxParticipants { get; set; }
  
        
        /// <summary>
        /// On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording
        /// </summary>
        /// <value>On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording</value>
        [DataMember(Name="recordingState", EmitDefaultValue=false)]
        public string RecordingState { get; set; }
  
        
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
            sb.Append("class Conversation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Participants: ").Append(Participants).Append("\n");
            sb.Append("  ConversationIds: ").Append(ConversationIds).Append("\n");
            sb.Append("  MaxParticipants: ").Append(MaxParticipants).Append("\n");
            sb.Append("  RecordingState: ").Append(RecordingState).Append("\n");
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
            return this.Equals(obj as Conversation);
        }

        /// <summary>
        /// Returns true if Conversation instances are equal
        /// </summary>
        /// <param name="obj">Instance of Conversation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Conversation other)
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
                    this.Participants == other.Participants ||
                    this.Participants != null &&
                    this.Participants.SequenceEqual(other.Participants)
                ) && 
                (
                    this.ConversationIds == other.ConversationIds ||
                    this.ConversationIds != null &&
                    this.ConversationIds.SequenceEqual(other.ConversationIds)
                ) && 
                (
                    this.MaxParticipants == other.MaxParticipants ||
                    this.MaxParticipants != null &&
                    this.MaxParticipants.Equals(other.MaxParticipants)
                ) && 
                (
                    this.RecordingState == other.RecordingState ||
                    this.RecordingState != null &&
                    this.RecordingState.Equals(other.RecordingState)
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
                
                if (this.StartTime != null)
                    hash = hash * 57 + this.StartTime.GetHashCode();
                
                if (this.EndTime != null)
                    hash = hash * 57 + this.EndTime.GetHashCode();
                
                if (this.Participants != null)
                    hash = hash * 57 + this.Participants.GetHashCode();
                
                if (this.ConversationIds != null)
                    hash = hash * 57 + this.ConversationIds.GetHashCode();
                
                if (this.MaxParticipants != null)
                    hash = hash * 57 + this.MaxParticipants.GetHashCode();
                
                if (this.RecordingState != null)
                    hash = hash * 57 + this.RecordingState.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
