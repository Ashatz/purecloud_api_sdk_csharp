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
    /// Participant
    /// </summary>
    [DataContract]
    public partial class Participant :  IEquatable<Participant>
    {
        /// <summary>
        /// Gets or Sets WrapupPrompt
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WrapupPromptEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Mandatory for "MANDATORY"
            /// </summary>
            [EnumMember(Value = "MANDATORY")]
            Mandatory,
            
            /// <summary>
            /// Enum Optional for "OPTIONAL"
            /// </summary>
            [EnumMember(Value = "OPTIONAL")]
            Optional,
            
            /// <summary>
            /// Enum Timeout for "TIMEOUT"
            /// </summary>
            [EnumMember(Value = "TIMEOUT")]
            Timeout,
            
            /// <summary>
            /// Enum ForcedTimeout for "FORCED_TIMEOUT"
            /// </summary>
            [EnumMember(Value = "FORCED_TIMEOUT")]
            ForcedTimeout
        }
        /// <summary>
        /// Gets or Sets WrapupPrompt
        /// </summary>
        [DataMember(Name="wrapupPrompt", EmitDefaultValue=false)]
        public WrapupPromptEnum? WrapupPrompt { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Participant" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="StartTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="EndTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ConnectedTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Name">Name.</param>
        /// <param name="UserUri">UserUri.</param>
        /// <param name="UserId">UserId.</param>
        /// <param name="ExternalContactId">ExternalContactId.</param>
        /// <param name="QueueId">QueueId.</param>
        /// <param name="GroupId">GroupId.</param>
        /// <param name="QueueName">QueueName.</param>
        /// <param name="Purpose">Purpose.</param>
        /// <param name="ParticipantType">ParticipantType.</param>
        /// <param name="ConsultParticipantId">ConsultParticipantId.</param>
        /// <param name="Address">Address.</param>
        /// <param name="Ani">Ani.</param>
        /// <param name="Dnis">Dnis.</param>
        /// <param name="Locale">Locale.</param>
        /// <param name="WrapupRequired">WrapupRequired (default to false).</param>
        /// <param name="WrapupPrompt">WrapupPrompt.</param>
        /// <param name="WrapupTimeoutMs">WrapupTimeoutMs.</param>
        /// <param name="WrapupSkipped">WrapupSkipped (default to false).</param>
        /// <param name="Wrapup">Wrapup.</param>
        /// <param name="MonitoredParticipantId">MonitoredParticipantId.</param>
        /// <param name="Attributes">Attributes.</param>
        /// <param name="Calls">Calls.</param>
        /// <param name="Callbacks">Callbacks.</param>
        /// <param name="Chats">Chats.</param>
        /// <param name="Emails">Emails.</param>
        /// <param name="SocialExpressions">SocialExpressions.</param>
        /// <param name="Videos">Videos.</param>
        /// <param name="Evaluations">Evaluations.</param>
        public Participant(string Id = null, DateTime? StartTime = null, DateTime? EndTime = null, DateTime? ConnectedTime = null, string Name = null, string UserUri = null, string UserId = null, string ExternalContactId = null, string QueueId = null, string GroupId = null, string QueueName = null, string Purpose = null, string ParticipantType = null, string ConsultParticipantId = null, string Address = null, string Ani = null, string Dnis = null, string Locale = null, bool? WrapupRequired = null, WrapupPromptEnum? WrapupPrompt = null, int? WrapupTimeoutMs = null, bool? WrapupSkipped = null, Wrapup Wrapup = null, string MonitoredParticipantId = null, Dictionary<string, string> Attributes = null, List<Call> Calls = null, List<Callback> Callbacks = null, List<ConversationChat> Chats = null, List<Email> Emails = null, List<SocialExpression> SocialExpressions = null, List<Video> Videos = null, List<Evaluation> Evaluations = null)
        {
            this.Id = Id;
            this.StartTime = StartTime;
            this.EndTime = EndTime;
            this.ConnectedTime = ConnectedTime;
            this.Name = Name;
            this.UserUri = UserUri;
            this.UserId = UserId;
            this.ExternalContactId = ExternalContactId;
            this.QueueId = QueueId;
            this.GroupId = GroupId;
            this.QueueName = QueueName;
            this.Purpose = Purpose;
            this.ParticipantType = ParticipantType;
            this.ConsultParticipantId = ConsultParticipantId;
            this.Address = Address;
            this.Ani = Ani;
            this.Dnis = Dnis;
            this.Locale = Locale;
            // use default value if no "WrapupRequired" provided
            if (WrapupRequired == null)
            {
                this.WrapupRequired = false;
            }
            else
            {
                this.WrapupRequired = WrapupRequired;
            }
            this.WrapupPrompt = WrapupPrompt;
            this.WrapupTimeoutMs = WrapupTimeoutMs;
            // use default value if no "WrapupSkipped" provided
            if (WrapupSkipped == null)
            {
                this.WrapupSkipped = false;
            }
            else
            {
                this.WrapupSkipped = WrapupSkipped;
            }
            this.Wrapup = Wrapup;
            this.MonitoredParticipantId = MonitoredParticipantId;
            this.Attributes = Attributes;
            this.Calls = Calls;
            this.Callbacks = Callbacks;
            this.Chats = Chats;
            this.Emails = Emails;
            this.SocialExpressions = SocialExpressions;
            this.Videos = Videos;
            this.Evaluations = Evaluations;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
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
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="connectedTime", EmitDefaultValue=false)]
        public DateTime? ConnectedTime { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets UserUri
        /// </summary>
        [DataMember(Name="userUri", EmitDefaultValue=false)]
        public string UserUri { get; set; }
        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public string UserId { get; set; }
        /// <summary>
        /// Gets or Sets ExternalContactId
        /// </summary>
        [DataMember(Name="externalContactId", EmitDefaultValue=false)]
        public string ExternalContactId { get; set; }
        /// <summary>
        /// Gets or Sets QueueId
        /// </summary>
        [DataMember(Name="queueId", EmitDefaultValue=false)]
        public string QueueId { get; set; }
        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name="groupId", EmitDefaultValue=false)]
        public string GroupId { get; set; }
        /// <summary>
        /// Gets or Sets QueueName
        /// </summary>
        [DataMember(Name="queueName", EmitDefaultValue=false)]
        public string QueueName { get; set; }
        /// <summary>
        /// Gets or Sets Purpose
        /// </summary>
        [DataMember(Name="purpose", EmitDefaultValue=false)]
        public string Purpose { get; set; }
        /// <summary>
        /// Gets or Sets ParticipantType
        /// </summary>
        [DataMember(Name="participantType", EmitDefaultValue=false)]
        public string ParticipantType { get; set; }
        /// <summary>
        /// Gets or Sets ConsultParticipantId
        /// </summary>
        [DataMember(Name="consultParticipantId", EmitDefaultValue=false)]
        public string ConsultParticipantId { get; set; }
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
        /// <summary>
        /// Gets or Sets Ani
        /// </summary>
        [DataMember(Name="ani", EmitDefaultValue=false)]
        public string Ani { get; set; }
        /// <summary>
        /// Gets or Sets Dnis
        /// </summary>
        [DataMember(Name="dnis", EmitDefaultValue=false)]
        public string Dnis { get; set; }
        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name="locale", EmitDefaultValue=false)]
        public string Locale { get; set; }
        /// <summary>
        /// Gets or Sets WrapupRequired
        /// </summary>
        [DataMember(Name="wrapupRequired", EmitDefaultValue=false)]
        public bool? WrapupRequired { get; set; }
        /// <summary>
        /// Gets or Sets WrapupTimeoutMs
        /// </summary>
        [DataMember(Name="wrapupTimeoutMs", EmitDefaultValue=false)]
        public int? WrapupTimeoutMs { get; set; }
        /// <summary>
        /// Gets or Sets WrapupSkipped
        /// </summary>
        [DataMember(Name="wrapupSkipped", EmitDefaultValue=false)]
        public bool? WrapupSkipped { get; set; }
        /// <summary>
        /// Gets or Sets Wrapup
        /// </summary>
        [DataMember(Name="wrapup", EmitDefaultValue=false)]
        public Wrapup Wrapup { get; set; }
        /// <summary>
        /// Gets or Sets MonitoredParticipantId
        /// </summary>
        [DataMember(Name="monitoredParticipantId", EmitDefaultValue=false)]
        public string MonitoredParticipantId { get; set; }
        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Dictionary<string, string> Attributes { get; set; }
        /// <summary>
        /// Gets or Sets Calls
        /// </summary>
        [DataMember(Name="calls", EmitDefaultValue=false)]
        public List<Call> Calls { get; set; }
        /// <summary>
        /// Gets or Sets Callbacks
        /// </summary>
        [DataMember(Name="callbacks", EmitDefaultValue=false)]
        public List<Callback> Callbacks { get; set; }
        /// <summary>
        /// Gets or Sets Chats
        /// </summary>
        [DataMember(Name="chats", EmitDefaultValue=false)]
        public List<ConversationChat> Chats { get; set; }
        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name="emails", EmitDefaultValue=false)]
        public List<Email> Emails { get; set; }
        /// <summary>
        /// Gets or Sets SocialExpressions
        /// </summary>
        [DataMember(Name="socialExpressions", EmitDefaultValue=false)]
        public List<SocialExpression> SocialExpressions { get; set; }
        /// <summary>
        /// Gets or Sets Videos
        /// </summary>
        [DataMember(Name="videos", EmitDefaultValue=false)]
        public List<Video> Videos { get; set; }
        /// <summary>
        /// Gets or Sets Evaluations
        /// </summary>
        [DataMember(Name="evaluations", EmitDefaultValue=false)]
        public List<Evaluation> Evaluations { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Participant {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UserUri: ").Append(UserUri).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
            sb.Append("  QueueId: ").Append(QueueId).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  QueueName: ").Append(QueueName).Append("\n");
            sb.Append("  Purpose: ").Append(Purpose).Append("\n");
            sb.Append("  ParticipantType: ").Append(ParticipantType).Append("\n");
            sb.Append("  ConsultParticipantId: ").Append(ConsultParticipantId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Ani: ").Append(Ani).Append("\n");
            sb.Append("  Dnis: ").Append(Dnis).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  WrapupRequired: ").Append(WrapupRequired).Append("\n");
            sb.Append("  WrapupPrompt: ").Append(WrapupPrompt).Append("\n");
            sb.Append("  WrapupTimeoutMs: ").Append(WrapupTimeoutMs).Append("\n");
            sb.Append("  WrapupSkipped: ").Append(WrapupSkipped).Append("\n");
            sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
            sb.Append("  MonitoredParticipantId: ").Append(MonitoredParticipantId).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Calls: ").Append(Calls).Append("\n");
            sb.Append("  Callbacks: ").Append(Callbacks).Append("\n");
            sb.Append("  Chats: ").Append(Chats).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  SocialExpressions: ").Append(SocialExpressions).Append("\n");
            sb.Append("  Videos: ").Append(Videos).Append("\n");
            sb.Append("  Evaluations: ").Append(Evaluations).Append("\n");
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
            return this.Equals(obj as Participant);
        }

        /// <summary>
        /// Returns true if Participant instances are equal
        /// </summary>
        /// <param name="other">Instance of Participant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Participant other)
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
                    this.ConnectedTime == other.ConnectedTime ||
                    this.ConnectedTime != null &&
                    this.ConnectedTime.Equals(other.ConnectedTime)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.UserUri == other.UserUri ||
                    this.UserUri != null &&
                    this.UserUri.Equals(other.UserUri)
                ) &&
                (
                    this.UserId == other.UserId ||
                    this.UserId != null &&
                    this.UserId.Equals(other.UserId)
                ) &&
                (
                    this.ExternalContactId == other.ExternalContactId ||
                    this.ExternalContactId != null &&
                    this.ExternalContactId.Equals(other.ExternalContactId)
                ) &&
                (
                    this.QueueId == other.QueueId ||
                    this.QueueId != null &&
                    this.QueueId.Equals(other.QueueId)
                ) &&
                (
                    this.GroupId == other.GroupId ||
                    this.GroupId != null &&
                    this.GroupId.Equals(other.GroupId)
                ) &&
                (
                    this.QueueName == other.QueueName ||
                    this.QueueName != null &&
                    this.QueueName.Equals(other.QueueName)
                ) &&
                (
                    this.Purpose == other.Purpose ||
                    this.Purpose != null &&
                    this.Purpose.Equals(other.Purpose)
                ) &&
                (
                    this.ParticipantType == other.ParticipantType ||
                    this.ParticipantType != null &&
                    this.ParticipantType.Equals(other.ParticipantType)
                ) &&
                (
                    this.ConsultParticipantId == other.ConsultParticipantId ||
                    this.ConsultParticipantId != null &&
                    this.ConsultParticipantId.Equals(other.ConsultParticipantId)
                ) &&
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.Ani == other.Ani ||
                    this.Ani != null &&
                    this.Ani.Equals(other.Ani)
                ) &&
                (
                    this.Dnis == other.Dnis ||
                    this.Dnis != null &&
                    this.Dnis.Equals(other.Dnis)
                ) &&
                (
                    this.Locale == other.Locale ||
                    this.Locale != null &&
                    this.Locale.Equals(other.Locale)
                ) &&
                (
                    this.WrapupRequired == other.WrapupRequired ||
                    this.WrapupRequired != null &&
                    this.WrapupRequired.Equals(other.WrapupRequired)
                ) &&
                (
                    this.WrapupPrompt == other.WrapupPrompt ||
                    this.WrapupPrompt != null &&
                    this.WrapupPrompt.Equals(other.WrapupPrompt)
                ) &&
                (
                    this.WrapupTimeoutMs == other.WrapupTimeoutMs ||
                    this.WrapupTimeoutMs != null &&
                    this.WrapupTimeoutMs.Equals(other.WrapupTimeoutMs)
                ) &&
                (
                    this.WrapupSkipped == other.WrapupSkipped ||
                    this.WrapupSkipped != null &&
                    this.WrapupSkipped.Equals(other.WrapupSkipped)
                ) &&
                (
                    this.Wrapup == other.Wrapup ||
                    this.Wrapup != null &&
                    this.Wrapup.Equals(other.Wrapup)
                ) &&
                (
                    this.MonitoredParticipantId == other.MonitoredParticipantId ||
                    this.MonitoredParticipantId != null &&
                    this.MonitoredParticipantId.Equals(other.MonitoredParticipantId)
                ) &&
                (
                    this.Attributes == other.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(other.Attributes)
                ) &&
                (
                    this.Calls == other.Calls ||
                    this.Calls != null &&
                    this.Calls.SequenceEqual(other.Calls)
                ) &&
                (
                    this.Callbacks == other.Callbacks ||
                    this.Callbacks != null &&
                    this.Callbacks.SequenceEqual(other.Callbacks)
                ) &&
                (
                    this.Chats == other.Chats ||
                    this.Chats != null &&
                    this.Chats.SequenceEqual(other.Chats)
                ) &&
                (
                    this.Emails == other.Emails ||
                    this.Emails != null &&
                    this.Emails.SequenceEqual(other.Emails)
                ) &&
                (
                    this.SocialExpressions == other.SocialExpressions ||
                    this.SocialExpressions != null &&
                    this.SocialExpressions.SequenceEqual(other.SocialExpressions)
                ) &&
                (
                    this.Videos == other.Videos ||
                    this.Videos != null &&
                    this.Videos.SequenceEqual(other.Videos)
                ) &&
                (
                    this.Evaluations == other.Evaluations ||
                    this.Evaluations != null &&
                    this.Evaluations.SequenceEqual(other.Evaluations)
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
                if (this.StartTime != null)
                    hash = hash * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hash = hash * 59 + this.EndTime.GetHashCode();
                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.UserUri != null)
                    hash = hash * 59 + this.UserUri.GetHashCode();
                if (this.UserId != null)
                    hash = hash * 59 + this.UserId.GetHashCode();
                if (this.ExternalContactId != null)
                    hash = hash * 59 + this.ExternalContactId.GetHashCode();
                if (this.QueueId != null)
                    hash = hash * 59 + this.QueueId.GetHashCode();
                if (this.GroupId != null)
                    hash = hash * 59 + this.GroupId.GetHashCode();
                if (this.QueueName != null)
                    hash = hash * 59 + this.QueueName.GetHashCode();
                if (this.Purpose != null)
                    hash = hash * 59 + this.Purpose.GetHashCode();
                if (this.ParticipantType != null)
                    hash = hash * 59 + this.ParticipantType.GetHashCode();
                if (this.ConsultParticipantId != null)
                    hash = hash * 59 + this.ConsultParticipantId.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Ani != null)
                    hash = hash * 59 + this.Ani.GetHashCode();
                if (this.Dnis != null)
                    hash = hash * 59 + this.Dnis.GetHashCode();
                if (this.Locale != null)
                    hash = hash * 59 + this.Locale.GetHashCode();
                if (this.WrapupRequired != null)
                    hash = hash * 59 + this.WrapupRequired.GetHashCode();
                if (this.WrapupPrompt != null)
                    hash = hash * 59 + this.WrapupPrompt.GetHashCode();
                if (this.WrapupTimeoutMs != null)
                    hash = hash * 59 + this.WrapupTimeoutMs.GetHashCode();
                if (this.WrapupSkipped != null)
                    hash = hash * 59 + this.WrapupSkipped.GetHashCode();
                if (this.Wrapup != null)
                    hash = hash * 59 + this.Wrapup.GetHashCode();
                if (this.MonitoredParticipantId != null)
                    hash = hash * 59 + this.MonitoredParticipantId.GetHashCode();
                if (this.Attributes != null)
                    hash = hash * 59 + this.Attributes.GetHashCode();
                if (this.Calls != null)
                    hash = hash * 59 + this.Calls.GetHashCode();
                if (this.Callbacks != null)
                    hash = hash * 59 + this.Callbacks.GetHashCode();
                if (this.Chats != null)
                    hash = hash * 59 + this.Chats.GetHashCode();
                if (this.Emails != null)
                    hash = hash * 59 + this.Emails.GetHashCode();
                if (this.SocialExpressions != null)
                    hash = hash * 59 + this.SocialExpressions.GetHashCode();
                if (this.Videos != null)
                    hash = hash * 59 + this.Videos.GetHashCode();
                if (this.Evaluations != null)
                    hash = hash * 59 + this.Evaluations.GetHashCode();
                return hash;
            }
        }
    }

}
