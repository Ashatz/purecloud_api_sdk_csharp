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
    /// Video
    /// </summary>
    [DataContract]
    public partial class Video :  IEquatable<Video>
    {
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
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
        /// Gets or Sets DisconnectType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisconnectTypeEnum
        {
            
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
            Other
        }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Gets or Sets DisconnectType
        /// </summary>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Video" /> class.
        /// </summary>
        /// <param name="State">State.</param>
        /// <param name="Id">Id.</param>
        /// <param name="Context">Context.</param>
        /// <param name="AudioMuted">AudioMuted (default to false).</param>
        /// <param name="VideoMuted">VideoMuted (default to false).</param>
        /// <param name="SharingScreen">SharingScreen (default to false).</param>
        /// <param name="PeerCount">PeerCount.</param>
        /// <param name="DisconnectType">DisconnectType.</param>
        /// <param name="ConnectedTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DisconnectedTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        public Video(StateEnum? State = null, string Id = null, string Context = null, bool? AudioMuted = null, bool? VideoMuted = null, bool? SharingScreen = null, int? PeerCount = null, DisconnectTypeEnum? DisconnectType = null, DateTime? ConnectedTime = null, DateTime? DisconnectedTime = null)
        {
            this.State = State;
            this.Id = Id;
            this.Context = Context;
            // use default value if no "AudioMuted" provided
            if (AudioMuted == null)
            {
                this.AudioMuted = false;
            }
            else
            {
                this.AudioMuted = AudioMuted;
            }
            // use default value if no "VideoMuted" provided
            if (VideoMuted == null)
            {
                this.VideoMuted = false;
            }
            else
            {
                this.VideoMuted = VideoMuted;
            }
            // use default value if no "SharingScreen" provided
            if (SharingScreen == null)
            {
                this.SharingScreen = false;
            }
            else
            {
                this.SharingScreen = SharingScreen;
            }
            this.PeerCount = PeerCount;
            this.DisconnectType = DisconnectType;
            this.ConnectedTime = ConnectedTime;
            this.DisconnectedTime = DisconnectedTime;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name="context", EmitDefaultValue=false)]
        public string Context { get; set; }
        /// <summary>
        /// Gets or Sets AudioMuted
        /// </summary>
        [DataMember(Name="audioMuted", EmitDefaultValue=false)]
        public bool? AudioMuted { get; set; }
        /// <summary>
        /// Gets or Sets VideoMuted
        /// </summary>
        [DataMember(Name="videoMuted", EmitDefaultValue=false)]
        public bool? VideoMuted { get; set; }
        /// <summary>
        /// Gets or Sets SharingScreen
        /// </summary>
        [DataMember(Name="sharingScreen", EmitDefaultValue=false)]
        public bool? SharingScreen { get; set; }
        /// <summary>
        /// Gets or Sets PeerCount
        /// </summary>
        [DataMember(Name="peerCount", EmitDefaultValue=false)]
        public int? PeerCount { get; set; }
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Video {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  AudioMuted: ").Append(AudioMuted).Append("\n");
            sb.Append("  VideoMuted: ").Append(VideoMuted).Append("\n");
            sb.Append("  SharingScreen: ").Append(SharingScreen).Append("\n");
            sb.Append("  PeerCount: ").Append(PeerCount).Append("\n");
            sb.Append("  DisconnectType: ").Append(DisconnectType).Append("\n");
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
            return this.Equals(obj as Video);
        }

        /// <summary>
        /// Returns true if Video instances are equal
        /// </summary>
        /// <param name="other">Instance of Video to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Video other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
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
                    this.Context == other.Context ||
                    this.Context != null &&
                    this.Context.Equals(other.Context)
                ) && 
                (
                    this.AudioMuted == other.AudioMuted ||
                    this.AudioMuted != null &&
                    this.AudioMuted.Equals(other.AudioMuted)
                ) && 
                (
                    this.VideoMuted == other.VideoMuted ||
                    this.VideoMuted != null &&
                    this.VideoMuted.Equals(other.VideoMuted)
                ) && 
                (
                    this.SharingScreen == other.SharingScreen ||
                    this.SharingScreen != null &&
                    this.SharingScreen.Equals(other.SharingScreen)
                ) && 
                (
                    this.PeerCount == other.PeerCount ||
                    this.PeerCount != null &&
                    this.PeerCount.Equals(other.PeerCount)
                ) && 
                (
                    this.DisconnectType == other.DisconnectType ||
                    this.DisconnectType != null &&
                    this.DisconnectType.Equals(other.DisconnectType)
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
                if (this.Context != null)
                    hash = hash * 59 + this.Context.GetHashCode();
                if (this.AudioMuted != null)
                    hash = hash * 59 + this.AudioMuted.GetHashCode();
                if (this.VideoMuted != null)
                    hash = hash * 59 + this.VideoMuted.GetHashCode();
                if (this.SharingScreen != null)
                    hash = hash * 59 + this.SharingScreen.GetHashCode();
                if (this.PeerCount != null)
                    hash = hash * 59 + this.PeerCount.GetHashCode();
                if (this.DisconnectType != null)
                    hash = hash * 59 + this.DisconnectType.GetHashCode();
                if (this.ConnectedTime != null)
                    hash = hash * 59 + this.ConnectedTime.GetHashCode();
                if (this.DisconnectedTime != null)
                    hash = hash * 59 + this.DisconnectedTime.GetHashCode();
                return hash;
            }
        }
    }

}
