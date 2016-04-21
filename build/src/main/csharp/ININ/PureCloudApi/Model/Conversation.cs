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
    public partial class Conversation :  IEquatable<Conversation>
    { 

        /// <summary>
<<<<<<< HEAD
        /// On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording
        /// </summary>
        /// <value>On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording</value>
=======
        /// On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording.
        /// </summary>
        /// <value>On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording.</value>
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RecordingStateEnum {
            
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            [EnumMember(Value = "PAUSED")]
            Paused,
            
            [EnumMember(Value = "NONE")]
            None
        }

        

        /// <summary>
        /// On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording
        /// </summary>
        /// <value>On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording</value>
        [DataMember(Name="recordingState", EmitDefaultValue=false)]
        public RecordingStateEnum? RecordingState { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="StartTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="EndTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Participants">Participants.</param>
        /// <param name="ConversationIds">ConversationIds.</param>
        /// <param name="MaxParticipants">MaxParticipants.</param>
        /// <param name="RecordingState">On update, &#39;paused&#39; initiates a secure pause, &#39;active&#39; resumes any paused recordings; otherwise indicates state of conversation recording.</param>

        public Conversation(string Name = null, DateTime? StartTime = null, DateTime? EndTime = null, List<Participant> Participants = null, List<string> ConversationIds = null, int? MaxParticipants = null, RecordingStateEnum? RecordingState = null)
        {
            this.Name = Name;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.Participants = Participants;
            this.ConversationIds = ConversationIds;
            this.MaxParticipants = MaxParticipants;
            this.RecordingState = RecordingState;
            
        }

    
        /// <summary>
        /// On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording.
        /// </summary>
        /// <value>On update, 'paused' initiates a secure pause, 'active' resumes any paused recordings; otherwise indicates state of conversation recording.</value>
        [DataMember(Name="recordingState", EmitDefaultValue=false)]
        public RecordingStateEnum? RecordingState { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="StartTime">The time when the conversation started. This will be the time when the first participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (required).</param>
        /// <param name="EndTime">The time when the conversation ended. This will be the time when the last participant left the conversation, or null when the conversation is still active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Address">The address of the conversation as seen from an external participant. For phone calls this will be the DNIS for inbound calls and the ANI for outbound calls. For other media types this will be the address of the destination participant for inbound and the address of the initiating participant for outbound..</param>
        /// <param name="Participants">The list of all participants in the conversation. (required).</param>
        /// <param name="ConversationIds">A list of conversations to merge into this conversation to create a conference. This field is null except when being used to create a conference..</param>
        /// <param name="MaxParticipants">If this is a conference conversation, then this field indicates the maximum number of participants allowed to participant in the conference..</param>
        /// <param name="RecordingState">On update, &#39;paused&#39; initiates a secure pause, &#39;active&#39; resumes any paused recordings; otherwise indicates state of conversation recording..</param>

        public Conversation(string Name = null, DateTime? StartTime = null, DateTime? EndTime = null, string Address = null, List<Participant> Participants = null, List<string> ConversationIds = null, int? MaxParticipants = null, RecordingStateEnum? RecordingState = null)
        {
            // to ensure "StartTime" is required (not null)
            if (StartTime == null)
            {
                throw new InvalidDataException("StartTime is a required property for Conversation and cannot be null");
            }
            else
            {
                this.StartTime = StartTime;
            }
            // to ensure "Participants" is required (not null)
            if (Participants == null)
            {
                throw new InvalidDataException("Participants is a required property for Conversation and cannot be null");
            }
            else
            {
                this.Participants = Participants;
            }
            this.Name = Name;
            this.EndTime = EndTime;
            this.Address = Address;
            this.ConversationIds = ConversationIds;
            this.MaxParticipants = MaxParticipants;
            this.RecordingState = RecordingState;
            
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
        /// The time when the conversation started. This will be the time when the first participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when the conversation started. This will be the time when the first participant joined the conversation. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }
    
        /// <summary>
        /// The time when the conversation ended. This will be the time when the last participant left the conversation, or null when the conversation is still active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The time when the conversation ended. This will be the time when the last participant left the conversation, or null when the conversation is still active. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }
    
<<<<<<< HEAD
=======
        /// <summary>
        /// The address of the conversation as seen from an external participant. For phone calls this will be the DNIS for inbound calls and the ANI for outbound calls. For other media types this will be the address of the destination participant for inbound and the address of the initiating participant for outbound.
        /// </summary>
        /// <value>The address of the conversation as seen from an external participant. For phone calls this will be the DNIS for inbound calls and the ANI for outbound calls. For other media types this will be the address of the destination participant for inbound and the address of the initiating participant for outbound.</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
    
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// The list of all participants in the conversation.
        /// </summary>
        /// <value>The list of all participants in the conversation.</value>
        [DataMember(Name="participants", EmitDefaultValue=false)]
        public List<Participant> Participants { get; set; }
    
        /// <summary>
        /// A list of conversations to merge into this conversation to create a conference. This field is null except when being used to create a conference.
        /// </summary>
        /// <value>A list of conversations to merge into this conversation to create a conference. This field is null except when being used to create a conference.</value>
        [DataMember(Name="conversationIds", EmitDefaultValue=false)]
        public List<string> ConversationIds { get; set; }
    
        /// <summary>
        /// If this is a conference conversation, then this field indicates the maximum number of participants allowed to participant in the conference.
        /// </summary>
        /// <value>If this is a conference conversation, then this field indicates the maximum number of participants allowed to participant in the conference.</value>
        [DataMember(Name="maxParticipants", EmitDefaultValue=false)]
        public int? MaxParticipants { get; set; }
    
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
            sb.Append("class Conversation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
        /// <param name="other">Instance of Conversation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Conversation other)
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
                    this.StartTime == other.StartTime ||
                    this.StartTime != null &&
                    this.StartTime.Equals(other.StartTime)
                ) &&
                (
                    this.EndTime == other.EndTime ||
                    this.EndTime != null &&
                    this.EndTime.Equals(other.EndTime)
                ) &&
<<<<<<< HEAD
=======
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
<<<<<<< HEAD
=======
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                if (this.Participants != null)
                    hash = hash * 59 + this.Participants.GetHashCode();
                if (this.ConversationIds != null)
                    hash = hash * 59 + this.ConversationIds.GetHashCode();
                if (this.MaxParticipants != null)
                    hash = hash * 59 + this.MaxParticipants.GetHashCode();
                if (this.RecordingState != null)
                    hash = hash * 59 + this.RecordingState.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
