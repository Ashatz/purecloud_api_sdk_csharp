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
    /// SocialExpression
    /// </summary>
    [DataContract]
    public partial class SocialExpression :  IEquatable<SocialExpression>
    {
        /// <summary>
        /// The connection state of this communication.
        /// </summary>
        /// <value>The connection state of this communication.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Alerting for "ALERTING"
            /// </summary>
            [EnumMember(Value = "ALERTING")]
            Alerting,
            
            /// <summary>
            /// Enum Dialing for "DIALING"
            /// </summary>
            [EnumMember(Value = "DIALING")]
            Dialing,
            
            /// <summary>
            /// Enum Contacting for "CONTACTING"
            /// </summary>
            [EnumMember(Value = "CONTACTING")]
            Contacting,
            
            /// <summary>
            /// Enum Offering for "OFFERING"
            /// </summary>
            [EnumMember(Value = "OFFERING")]
            Offering,
            
            /// <summary>
            /// Enum Connected for "CONNECTED"
            /// </summary>
            [EnumMember(Value = "CONNECTED")]
            Connected,
            
            /// <summary>
            /// Enum Disconnected for "DISCONNECTED"
            /// </summary>
            [EnumMember(Value = "DISCONNECTED")]
            Disconnected,
            
            /// <summary>
            /// Enum Terminated for "TERMINATED"
            /// </summary>
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            
            /// <summary>
            /// Enum None for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            None
        }
        /// <summary>
        /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
        /// </summary>
        /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisconnectTypeEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Endpoint for "ENDPOINT"
            /// </summary>
            [EnumMember(Value = "ENDPOINT")]
            Endpoint,
            
            /// <summary>
            /// Enum Client for "CLIENT"
            /// </summary>
            [EnumMember(Value = "CLIENT")]
            Client,
            
            /// <summary>
            /// Enum System for "SYSTEM"
            /// </summary>
            [EnumMember(Value = "SYSTEM")]
            System,
            
            /// <summary>
            /// Enum Timeout for "TIMEOUT"
            /// </summary>
            [EnumMember(Value = "TIMEOUT")]
            Timeout,
            
            /// <summary>
            /// Enum Transfer for "TRANSFER"
            /// </summary>
            [EnumMember(Value = "TRANSFER")]
            Transfer,
            
            /// <summary>
            /// Enum TransferConference for "TRANSFER_CONFERENCE"
            /// </summary>
            [EnumMember(Value = "TRANSFER_CONFERENCE")]
            TransferConference,
            
            /// <summary>
            /// Enum TransferConsult for "TRANSFER_CONSULT"
            /// </summary>
            [EnumMember(Value = "TRANSFER_CONSULT")]
            TransferConsult,
            
            /// <summary>
            /// Enum TransferForward for "TRANSFER_FORWARD"
            /// </summary>
            [EnumMember(Value = "TRANSFER_FORWARD")]
            TransferForward,
            
            /// <summary>
            /// Enum TransferNoanswer for "TRANSFER_NOANSWER"
            /// </summary>
            [EnumMember(Value = "TRANSFER_NOANSWER")]
            TransferNoanswer,
            
            /// <summary>
            /// Enum TransferNotavailable for "TRANSFER_NOTAVAILABLE"
            /// </summary>
            [EnumMember(Value = "TRANSFER_NOTAVAILABLE")]
            TransferNotavailable,
            
            /// <summary>
            /// Enum TransportFailure for "TRANSPORT_FAILURE"
            /// </summary>
            [EnumMember(Value = "TRANSPORT_FAILURE")]
            TransportFailure,
            
            /// <summary>
            /// Enum Error for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            Error,
            
            /// <summary>
            /// Enum Peer for "PEER"
            /// </summary>
            [EnumMember(Value = "PEER")]
            Peer,
            
            /// <summary>
            /// Enum Other for "OTHER"
            /// </summary>
            [EnumMember(Value = "OTHER")]
            Other,
            
            /// <summary>
            /// Enum Spam for "SPAM"
            /// </summary>
            [EnumMember(Value = "SPAM")]
            Spam
        }
        /// <summary>
        /// The connection state of this communication.
        /// </summary>
        /// <value>The connection state of this communication.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
        /// </summary>
        /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialExpression" /> class.
        /// </summary>
        /// <param name="State">The connection state of this communication..</param>
        /// <param name="Id">A globally unique identifier for this communication..</param>
        /// <param name="SocialMediaId">A globally unique identifier for the social media..</param>
        /// <param name="SocialMediaHub">The social network of the communication.</param>
        /// <param name="SocialUserName">The user name for the communication..</param>
        /// <param name="PreviewText">The text preview of the communication contents.</param>
        /// <param name="RecordingId">A globally unique identifier for the recording associated with this chat..</param>
        /// <param name="Segments">The time line of the participant&#39;s chat, divided into activity segments..</param>
        /// <param name="Held">True if this call is held and the person on this side hears silence. (default to false).</param>
        /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
        /// <param name="StartHoldTime">The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        public SocialExpression(StateEnum? State = null, string Id = null, string SocialMediaId = null, string SocialMediaHub = null, string SocialUserName = null, string PreviewText = null, string RecordingId = null, List<Segment> Segments = null, bool? Held = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null)
        {
            this.State = State;
            this.Id = Id;
            this.SocialMediaId = SocialMediaId;
            this.SocialMediaHub = SocialMediaHub;
            this.SocialUserName = SocialUserName;
            this.PreviewText = PreviewText;
            this.RecordingId = RecordingId;
            this.Segments = Segments;
            // use default value if no "Held" provided
            if (Held == null)
            {
                this.Held = false;
            }
            else
            {
                this.Held = Held;
            }
            this.DisconnectType = DisconnectType;
            this.StartHoldTime = StartHoldTime;
            this.ConnectedTime = ConnectedTime;
            this.DisconnectedTime = DisconnectedTime;
        }
        
        /// <summary>
        /// A globally unique identifier for this communication.
        /// </summary>
        /// <value>A globally unique identifier for this communication.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// A globally unique identifier for the social media.
        /// </summary>
        /// <value>A globally unique identifier for the social media.</value>
        [DataMember(Name="socialMediaId", EmitDefaultValue=false)]
        public string SocialMediaId { get; set; }
        /// <summary>
        /// The social network of the communication
        /// </summary>
        /// <value>The social network of the communication</value>
        [DataMember(Name="socialMediaHub", EmitDefaultValue=false)]
        public string SocialMediaHub { get; set; }
        /// <summary>
        /// The user name for the communication.
        /// </summary>
        /// <value>The user name for the communication.</value>
        [DataMember(Name="socialUserName", EmitDefaultValue=false)]
        public string SocialUserName { get; set; }
        /// <summary>
        /// The text preview of the communication contents
        /// </summary>
        /// <value>The text preview of the communication contents</value>
        [DataMember(Name="previewText", EmitDefaultValue=false)]
        public string PreviewText { get; set; }
        /// <summary>
        /// A globally unique identifier for the recording associated with this chat.
        /// </summary>
        /// <value>A globally unique identifier for the recording associated with this chat.</value>
        [DataMember(Name="recordingId", EmitDefaultValue=false)]
        public string RecordingId { get; set; }
        /// <summary>
        /// The time line of the participant&#39;s chat, divided into activity segments.
        /// </summary>
        /// <value>The time line of the participant&#39;s chat, divided into activity segments.</value>
        [DataMember(Name="segments", EmitDefaultValue=false)]
        public List<Segment> Segments { get; set; }
        /// <summary>
        /// True if this call is held and the person on this side hears silence.
        /// </summary>
        /// <value>True if this call is held and the person on this side hears silence.</value>
        [DataMember(Name="held", EmitDefaultValue=false)]
        public bool? Held { get; set; }
        /// <summary>
        /// The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp the chat was placed on hold in the cloud clock if the chat is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startHoldTime", EmitDefaultValue=false)]
        public DateTime? StartHoldTime { get; set; }
        /// <summary>
        /// The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="connectedTime", EmitDefaultValue=false)]
        public DateTime? ConnectedTime { get; set; }
        /// <summary>
        /// The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="disconnectedTime", EmitDefaultValue=false)]
        public DateTime? DisconnectedTime { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocialExpression {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SocialMediaId: ").Append(SocialMediaId).Append("\n");
            sb.Append("  SocialMediaHub: ").Append(SocialMediaHub).Append("\n");
            sb.Append("  SocialUserName: ").Append(SocialUserName).Append("\n");
            sb.Append("  PreviewText: ").Append(PreviewText).Append("\n");
            sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
            sb.Append("  Held: ").Append(Held).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
            sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
            sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
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
            return this.Equals(obj as SocialExpression);
        }

        /// <summary>
        /// Returns true if SocialExpression instances are equal
        /// </summary>
        /// <param name="other">Instance of SocialExpression to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocialExpression other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) &&
                (
                    this.SocialMediaId == other.SocialMediaId ||
                    this.SocialMediaId != null &&
                    this.SocialMediaId.Equals(other.SocialMediaId)
                ) &&
                (
                    this.SocialMediaHub == other.SocialMediaHub ||
                    this.SocialMediaHub != null &&
                    this.SocialMediaHub.Equals(other.SocialMediaHub)
                ) &&
                (
                    this.SocialUserName == other.SocialUserName ||
                    this.SocialUserName != null &&
                    this.SocialUserName.Equals(other.SocialUserName)
                ) &&
                (
                    this.PreviewText == other.PreviewText ||
                    this.PreviewText != null &&
                    this.PreviewText.Equals(other.PreviewText)
                ) &&
                (
                    this.RecordingId == other.RecordingId ||
                    this.RecordingId != null &&
                    this.RecordingId.Equals(other.RecordingId)
                ) &&
                (
                    this.Segments == other.Segments ||
                    this.Segments != null &&
                    this.Segments.SequenceEqual(other.Segments)
                ) &&
                (
                    this.Held == other.Held ||
                    this.Held != null &&
                    this.Held.Equals(other.Held)
                ) &&
                (
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
                ) &&
                (
                    this.StartHoldTime == other.StartHoldTime ||
                    this.StartHoldTime != null &&
                    this.StartHoldTime.Equals(other.StartHoldTime)
                ) &&
                (
                    this.ConnectedTime == other.ConnectedTime ||
                    this.ConnectedTime != null &&
                    this.ConnectedTime.Equals(other.ConnectedTime)
                ) &&
                (
                    this.DisconnectedTime == other.DisconnectedTime ||
                    this.DisconnectedTime != null &&
                    this.DisconnectedTime.Equals(other.DisconnectedTime)
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
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.SocialMediaId != null)
                    hash = hash * 59 + this.SocialMediaId.GetHashCode();
                if (this.SocialMediaHub != null)
                    hash = hash * 59 + this.SocialMediaHub.GetHashCode();
                if (this.SocialUserName != null)
                    hash = hash * 59 + this.SocialUserName.GetHashCode();
                if (this.PreviewText != null)
                    hash = hash * 59 + this.PreviewText.GetHashCode();
                if (this.RecordingId != null)
                    hash = hash * 59 + this.RecordingId.GetHashCode();
                if (this.Segments != null)
                    hash = hash * 59 + this.Segments.GetHashCode();
                if (this.Held != null)
                    hash = hash * 59 + this.Held.GetHashCode();
                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();
                if (this.StartHoldTime != null)
                    hash = hash * 59 + this.StartHoldTime.GetHashCode();
                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();
                if (this.DisconnectedTime != null)
                    hash = hash * 59 + this.DisconnectedTime.GetHashCode();
                return hash;
            }
        }
    }

}
