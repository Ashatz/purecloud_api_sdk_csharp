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
    /// Call
    /// </summary>
    [DataContract]
    public partial class Call :  IEquatable<Call>
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
            /// Enum Converting for "CONVERTING"
            /// </summary>
            [EnumMember(Value = "CONVERTING")]
            Converting,
            
            /// <summary>
            /// Enum Uploading for "UPLOADING"
            /// </summary>
            [EnumMember(Value = "UPLOADING")]
            Uploading,
            
            /// <summary>
            /// Enum Transmitting for "TRANSMITTING"
            /// </summary>
            [EnumMember(Value = "TRANSMITTING")]
            Transmitting,
            
            /// <summary>
            /// Enum None for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            None
        }
        /// <summary>
        /// The direction of the call
        /// </summary>
        /// <value>The direction of the call</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum Inbound for "INBOUND"
            /// </summary>
            [EnumMember(Value = "INBOUND")]
            Inbound,
            
            /// <summary>
            /// Enum Outbound for "OUTBOUND"
            /// </summary>
            [EnumMember(Value = "OUTBOUND")]
            Outbound
        }
        /// <summary>
        /// State of recording on this call.
        /// </summary>
        /// <value>State of recording on this call.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecordingStateEnum
        {
            /// <summary>
            /// Your SDK version is out of date and an unknown enum value was encountered. 
            /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
            /// in the Package Manager Console
            /// </summary>
            [EnumMember(Value = "OUTDATED_SDK_VERSION")]
            OutdatedSdkVersion,
            
            /// <summary>
            /// Enum None for "NONE"
            /// </summary>
            [EnumMember(Value = "NONE")]
            None,
            
            /// <summary>
            /// Enum Active for "ACTIVE"
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            /// <summary>
            /// Enum Paused for "PAUSED"
            /// </summary>
            [EnumMember(Value = "PAUSED")]
            Paused
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
        /// The direction of the call
        /// </summary>
        /// <value>The direction of the call</value>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
        /// <summary>
        /// State of recording on this call.
        /// </summary>
        /// <value>State of recording on this call.</value>
        [DataMember(Name="recordingState", EmitDefaultValue=false)]
        public RecordingStateEnum? RecordingState { get; set; }
        /// <summary>
        /// System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.
        /// </summary>
        /// <value>System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects.</value>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Call" /> class.
        /// </summary>
        /// <param name="State">The connection state of this communication..</param>
        /// <param name="Id">A globally unique identifier for this communication..</param>
        /// <param name="Direction">The direction of the call.</param>
        /// <param name="Recording">True if this call is being recorded. (default to false).</param>
        /// <param name="RecordingState">State of recording on this call..</param>
        /// <param name="Muted">True if this call is muted so that remote participants can&#39;t hear any audio from this end. (default to false).</param>
        /// <param name="Confined">True if this call is held and the person on this side hears hold music. (default to false).</param>
        /// <param name="Held">True if this call is held and the person on this side hears silence. (default to false).</param>
        /// <param name="RecordingId">A globally unique identifier for the recording associated with this call..</param>
        /// <param name="Segments">The time line of the participant&#39;s call, divided into activity segments..</param>
        /// <param name="ErrorInfo">ErrorInfo.</param>
        /// <param name="DisconnectType">System defined string indicating what caused the communication to disconnect. Will be null until the communication disconnects..</param>
        /// <param name="StartHoldTime">The timestamp the call was placed on hold in the cloud clock if the call is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DocumentId">If call is an outbound fax of a document from content management, then this is the id in content management..</param>
        /// <param name="ConnectedTime">The timestamp when this communication was connected in the cloud clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DisconnectedTime">The timestamp when this communication disconnected from the conversation in the provider clock. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DisconnectReasons">List of reasons that this call was disconnected. This will be set once the call disconnects..</param>
        /// <param name="FaxStatus">Extra information on fax transmission..</param>
        public Call(StateEnum? State = null, string Id = null, DirectionEnum? Direction = null, bool? Recording = null, RecordingStateEnum? RecordingState = null, bool? Muted = null, bool? Confined = null, bool? Held = null, string RecordingId = null, List<Segment> Segments = null, ErrorBody ErrorInfo = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, string DocumentId = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, List<DisconnectReason> DisconnectReasons = null, FaxStatus FaxStatus = null)
        {
            this.State = State;
            this.Id = Id;
            this.Direction = Direction;
            // use default value if no "Recording" provided
            if (Recording == null)
            {
                this.Recording = false;
            }
            else
            {
                this.Recording = Recording;
            }
            this.RecordingState = RecordingState;
            // use default value if no "Muted" provided
            if (Muted == null)
            {
                this.Muted = false;
            }
            else
            {
                this.Muted = Muted;
            }
            // use default value if no "Confined" provided
            if (Confined == null)
            {
                this.Confined = false;
            }
            else
            {
                this.Confined = Confined;
            }
            // use default value if no "Held" provided
            if (Held == null)
            {
                this.Held = false;
            }
            else
            {
                this.Held = Held;
            }
            this.RecordingId = RecordingId;
            this.Segments = Segments;
            this.ErrorInfo = ErrorInfo;
            this.DisconnectType = DisconnectType;
            this.StartHoldTime = StartHoldTime;
            this.DocumentId = DocumentId;
            this.ConnectedTime = ConnectedTime;
            this.DisconnectedTime = DisconnectedTime;
            this.DisconnectReasons = DisconnectReasons;
            this.FaxStatus = FaxStatus;
        }
        
        /// <summary>
        /// A globally unique identifier for this communication.
        /// </summary>
        /// <value>A globally unique identifier for this communication.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// True if this call is being recorded.
        /// </summary>
        /// <value>True if this call is being recorded.</value>
        [DataMember(Name="recording", EmitDefaultValue=false)]
        public bool? Recording { get; set; }
        /// <summary>
        /// True if this call is muted so that remote participants can&#39;t hear any audio from this end.
        /// </summary>
        /// <value>True if this call is muted so that remote participants can&#39;t hear any audio from this end.</value>
        [DataMember(Name="muted", EmitDefaultValue=false)]
        public bool? Muted { get; set; }
        /// <summary>
        /// True if this call is held and the person on this side hears hold music.
        /// </summary>
        /// <value>True if this call is held and the person on this side hears hold music.</value>
        [DataMember(Name="confined", EmitDefaultValue=false)]
        public bool? Confined { get; set; }
        /// <summary>
        /// True if this call is held and the person on this side hears silence.
        /// </summary>
        /// <value>True if this call is held and the person on this side hears silence.</value>
        [DataMember(Name="held", EmitDefaultValue=false)]
        public bool? Held { get; set; }
        /// <summary>
        /// A globally unique identifier for the recording associated with this call.
        /// </summary>
        /// <value>A globally unique identifier for the recording associated with this call.</value>
        [DataMember(Name="recordingId", EmitDefaultValue=false)]
        public string RecordingId { get; set; }
        /// <summary>
        /// The time line of the participant&#39;s call, divided into activity segments.
        /// </summary>
        /// <value>The time line of the participant&#39;s call, divided into activity segments.</value>
        [DataMember(Name="segments", EmitDefaultValue=false)]
        public List<Segment> Segments { get; set; }
        /// <summary>
        /// Gets or Sets ErrorInfo
        /// </summary>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public ErrorBody ErrorInfo { get; set; }
        /// <summary>
        /// The timestamp the call was placed on hold in the cloud clock if the call is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The timestamp the call was placed on hold in the cloud clock if the call is currently on hold. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startHoldTime", EmitDefaultValue=false)]
        public DateTime? StartHoldTime { get; set; }
        /// <summary>
        /// If call is an outbound fax of a document from content management, then this is the id in content management.
        /// </summary>
        /// <value>If call is an outbound fax of a document from content management, then this is the id in content management.</value>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }
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
        /// List of reasons that this call was disconnected. This will be set once the call disconnects.
        /// </summary>
        /// <value>List of reasons that this call was disconnected. This will be set once the call disconnects.</value>
        [DataMember(Name="disconnectReasons", EmitDefaultValue=false)]
        public List<DisconnectReason> DisconnectReasons { get; set; }
        /// <summary>
        /// Extra information on fax transmission.
        /// </summary>
        /// <value>Extra information on fax transmission.</value>
        [DataMember(Name="faxStatus", EmitDefaultValue=false)]
        public FaxStatus FaxStatus { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Call {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Recording: ").Append(Recording).Append("\n");
            sb.Append("  RecordingState: ").Append(RecordingState).Append("\n");
            sb.Append("  Muted: ").Append(Muted).Append("\n");
            sb.Append("  Confined: ").Append(Confined).Append("\n");
            sb.Append("  Held: ").Append(Held).Append("\n");
            sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
            sb.Append("  Segments: ").Append(Segments).Append("\n");
            sb.Append("  ErrorInfo: ").Append(ErrorInfo).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
            sb.Append("  StartHoldTime: ").Append(StartHoldTime).Append("\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
            sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
            sb.Append("  DisconnectReasons: ").Append(DisconnectReasons).Append("\n");
            sb.Append("  FaxStatus: ").Append(FaxStatus).Append("\n");
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
            return this.Equals(obj as Call);
        }

        /// <summary>
        /// Returns true if Call instances are equal
        /// </summary>
        /// <param name="other">Instance of Call to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Call other)
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
                    this.Direction == other.Direction ||
                    this.Direction != null &&
                    this.Direction.Equals(other.Direction)
                ) &&
                (
                    this.Recording == other.Recording ||
                    this.Recording != null &&
                    this.Recording.Equals(other.Recording)
                ) &&
                (
                    this.RecordingState == other.RecordingState ||
                    this.RecordingState != null &&
                    this.RecordingState.Equals(other.RecordingState)
                ) &&
                (
                    this.Muted == other.Muted ||
                    this.Muted != null &&
                    this.Muted.Equals(other.Muted)
                ) &&
                (
                    this.Confined == other.Confined ||
                    this.Confined != null &&
                    this.Confined.Equals(other.Confined)
                ) &&
                (
                    this.Held == other.Held ||
                    this.Held != null &&
                    this.Held.Equals(other.Held)
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
                    this.ErrorInfo == other.ErrorInfo ||
                    this.ErrorInfo != null &&
                    this.ErrorInfo.Equals(other.ErrorInfo)
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
                    this.DocumentId == other.DocumentId ||
                    this.DocumentId != null &&
                    this.DocumentId.Equals(other.DocumentId)
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
                ) &&
                (
                    this.DisconnectReasons == other.DisconnectReasons ||
                    this.DisconnectReasons != null &&
                    this.DisconnectReasons.SequenceEqual(other.DisconnectReasons)
                ) &&
                (
                    this.FaxStatus == other.FaxStatus ||
                    this.FaxStatus != null &&
                    this.FaxStatus.Equals(other.FaxStatus)
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
                if (this.Direction != null)
                    hash = hash * 59 + this.Direction.GetHashCode();
                if (this.Recording != null)
                    hash = hash * 59 + this.Recording.GetHashCode();
                if (this.RecordingState != null)
                    hash = hash * 59 + this.RecordingState.GetHashCode();
                if (this.Muted != null)
                    hash = hash * 59 + this.Muted.GetHashCode();
                if (this.Confined != null)
                    hash = hash * 59 + this.Confined.GetHashCode();
                if (this.Held != null)
                    hash = hash * 59 + this.Held.GetHashCode();
                if (this.RecordingId != null)
                    hash = hash * 59 + this.RecordingId.GetHashCode();
                if (this.Segments != null)
                    hash = hash * 59 + this.Segments.GetHashCode();
                if (this.ErrorInfo != null)
                    hash = hash * 59 + this.ErrorInfo.GetHashCode();
                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();
                if (this.StartHoldTime != null)
                    hash = hash * 59 + this.StartHoldTime.GetHashCode();
                if (this.DocumentId != null)
                    hash = hash * 59 + this.DocumentId.GetHashCode();
                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();
                if (this.DisconnectedTime != null)
                    hash = hash * 59 + this.DisconnectedTime.GetHashCode();
                if (this.DisconnectReasons != null)
                    hash = hash * 59 + this.DisconnectReasons.GetHashCode();
                if (this.FaxStatus != null)
                    hash = hash * 59 + this.FaxStatus.GetHashCode();
                return hash;
            }
        }
    }

}
