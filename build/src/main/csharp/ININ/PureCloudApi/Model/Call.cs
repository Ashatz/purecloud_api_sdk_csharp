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
    public partial class Call :  IEquatable<Call>
    { 

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StateEnum {
            
            [EnumMember(Value = "ALERTING")]
            Alerting,
            
            [EnumMember(Value = "DIALING")]
            Dialing,
<<<<<<< HEAD
            
            [EnumMember(Value = "CONTACTING")]
            Contacting,
            
            [EnumMember(Value = "OFFERING")]
            Offering,
            
            [EnumMember(Value = "CONNECTED")]
            Connected,
            
            [EnumMember(Value = "DISCONNECTED")]
            Disconnected,
            
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            
            [EnumMember(Value = "NONE")]
            None
        }


        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DirectionEnum {
            
            [EnumMember(Value = "INBOUND")]
            Inbound,
            
            [EnumMember(Value = "OUTBOUND")]
            Outbound
        }


        /// <summary>
        /// Gets or Sets RecordingState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RecordingStateEnum {
            
            [EnumMember(Value = "NONE")]
            None,
            
=======
            
            [EnumMember(Value = "CONTACTING")]
            Contacting,
            
            [EnumMember(Value = "OFFERING")]
            Offering,
            
            [EnumMember(Value = "CONNECTED")]
            Connected,
            
            [EnumMember(Value = "DISCONNECTED")]
            Disconnected,
            
            [EnumMember(Value = "TERMINATED")]
            Terminated,
            
            [EnumMember(Value = "CONVERTING")]
            Converting,
            
            [EnumMember(Value = "UPLOADING")]
            Uploading,
            
            [EnumMember(Value = "TRANSMITTING")]
            Transmitting,
            
            [EnumMember(Value = "NONE")]
            None
        }


        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DirectionEnum {
            
            [EnumMember(Value = "INBOUND")]
            Inbound,
            
            [EnumMember(Value = "OUTBOUND")]
            Outbound
        }


        /// <summary>
        /// Gets or Sets RecordingState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum RecordingStateEnum {
            
            [EnumMember(Value = "NONE")]
            None,
            
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            [EnumMember(Value = "ACTIVE")]
            Active,
            
            [EnumMember(Value = "PAUSED")]
            Paused
        }


        /// <summary>
        /// Gets or Sets DisconnectType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DisconnectTypeEnum {
            
            [EnumMember(Value = "ENDPOINT")]
            Endpoint,
            
            [EnumMember(Value = "CLIENT")]
            Client,
            
            [EnumMember(Value = "SYSTEM")]
            System,
            
<<<<<<< HEAD
=======
            [EnumMember(Value = "TIMEOUT")]
            Timeout,
            
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            [EnumMember(Value = "TRANSFER")]
            Transfer,
            
            [EnumMember(Value = "TRANSFER_CONFERENCE")]
            TransferConference,
            
            [EnumMember(Value = "TRANSFER_CONSULT")]
            TransferConsult,
            
<<<<<<< HEAD
=======
            [EnumMember(Value = "TRANSFER_FORWARD")]
            TransferForward,
            
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            [EnumMember(Value = "ERROR")]
            Error,
            
            [EnumMember(Value = "PEER")]
            Peer,
            
            [EnumMember(Value = "OTHER")]
            Other
        }

        

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
    
<<<<<<< HEAD

=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public DirectionEnum? Direction { get; set; }
    
<<<<<<< HEAD

=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Gets or Sets RecordingState
        /// </summary>
        [DataMember(Name="recordingState", EmitDefaultValue=false)]
        public RecordingStateEnum? RecordingState { get; set; }
    
<<<<<<< HEAD

=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Gets or Sets DisconnectType
        /// </summary>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Call" />class.
        /// </summary>
        /// <param name="State">State.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Direction">Direction.</param>
        /// <param name="Recording">Recording (default to false).</param>
        /// <param name="RecordingState">RecordingState.</param>
        /// <param name="Muted">Muted (default to false).</param>
        /// <param name="Confined">Confined (default to false).</param>
        /// <param name="Held">Held (default to false).</param>
        /// <param name="RecordingId">RecordingId.</param>
        /// <param name="Segments">Segments.</param>
        /// <param name="ErrorInfo">ErrorInfo.</param>
        /// <param name="DisconnectType">DisconnectType.</param>
        /// <param name="StartHoldTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DocumentId">DocumentId.</param>
<<<<<<< HEAD

        public Call(StateEnum? State = null, string Id = null, DirectionEnum? Direction = null, bool? Recording = null, RecordingStateEnum? RecordingState = null, bool? Muted = null, bool? Confined = null, bool? Held = null, string RecordingId = null, List<Segment> Segments = null, ErrorBody ErrorInfo = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, string DocumentId = null)
=======
        /// <param name="ConnectedTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DisconnectedTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DisconnectReasons">DisconnectReasons.</param>

        public Call(StateEnum? State = null, string Id = null, DirectionEnum? Direction = null, bool? Recording = null, RecordingStateEnum? RecordingState = null, bool? Muted = null, bool? Confined = null, bool? Held = null, string RecordingId = null, List<Segment> Segments = null, ErrorBody ErrorInfo = null, DisconnectTypeEnum? DisconnectType = null, DateTime? StartHoldTime = null, string DocumentId = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null, List<DisconnectReason> DisconnectReasons = null)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
            this.ConnectedTime = ConnectedTime;
            this.DisconnectedTime = DisconnectedTime;
            this.DisconnectReasons = DisconnectReasons;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

    
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Recording
        /// </summary>
        [DataMember(Name="recording", EmitDefaultValue=false)]
        public bool? Recording { get; set; }
    
        /// <summary>
        /// Gets or Sets Muted
        /// </summary>
        [DataMember(Name="muted", EmitDefaultValue=false)]
        public bool? Muted { get; set; }
    
        /// <summary>
        /// Gets or Sets Confined
        /// </summary>
        [DataMember(Name="confined", EmitDefaultValue=false)]
        public bool? Confined { get; set; }
    
        /// <summary>
        /// Gets or Sets Held
        /// </summary>
        [DataMember(Name="held", EmitDefaultValue=false)]
        public bool? Held { get; set; }
    
        /// <summary>
        /// Gets or Sets RecordingId
        /// </summary>
        [DataMember(Name="recordingId", EmitDefaultValue=false)]
        public string RecordingId { get; set; }
    
        /// <summary>
        /// Gets or Sets Segments
        /// </summary>
        [DataMember(Name="segments", EmitDefaultValue=false)]
        public List<Segment> Segments { get; set; }
    
        /// <summary>
        /// Gets or Sets ErrorInfo
        /// </summary>
        [DataMember(Name="errorInfo", EmitDefaultValue=false)]
        public ErrorBody ErrorInfo { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startHoldTime", EmitDefaultValue=false)]
        public DateTime? StartHoldTime { get; set; }
    
        /// <summary>
        /// Gets or Sets DocumentId
        /// </summary>
        [DataMember(Name="documentId", EmitDefaultValue=false)]
        public string DocumentId { get; set; }
    
<<<<<<< HEAD
=======
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="connectedTime", EmitDefaultValue=false)]
        public DateTime? ConnectedTime { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="disconnectedTime", EmitDefaultValue=false)]
        public DateTime? DisconnectedTime { get; set; }
    
        /// <summary>
        /// Gets or Sets DisconnectReasons
        /// </summary>
        [DataMember(Name="disconnectReasons", EmitDefaultValue=false)]
        public List<DisconnectReason> DisconnectReasons { get; set; }
    
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
            sb.Append("  ConnectedTime: ").Append(ConnectedTime).Append("\n");
            sb.Append("  DisconnectedTime: ").Append(DisconnectedTime).Append("\n");
            sb.Append("  DisconnectReasons: ").Append(DisconnectReasons).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
=======
                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();
                if (this.DisconnectedTime != null)
                    hash = hash * 59 + this.DisconnectedTime.GetHashCode();
                if (this.DisconnectReasons != null)
                    hash = hash * 59 + this.DisconnectReasons.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                return hash;
            }
        }

    }
}
