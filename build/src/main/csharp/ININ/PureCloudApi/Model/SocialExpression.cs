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
    public partial class SocialExpression :  IEquatable<SocialExpression>
    { 
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum {
            
            [EnumMember(Value = "ALERTING")]
            Alerting,
            
            [EnumMember(Value = "DIALING")]
            Dialing,
            
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
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisconnectTypeEnum {
            
            [EnumMember(Value = "ENDPOINT")]
            Endpoint,
            
            [EnumMember(Value = "CLIENT")]
            Client,
            
            [EnumMember(Value = "SYSTEM")]
            System,
            
            [EnumMember(Value = "TRANSFER")]
            Transfer,
            
            [EnumMember(Value = "TRANSFER_CONFERENCE")]
            TransferConference,
            
            [EnumMember(Value = "TRANSFER_CONSULT")]
            TransferConsult,
            
            [EnumMember(Value = "TRANSFER_FORWARD")]
            TransferForward,
            
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
    
        /// <summary>
        /// Gets or Sets DisconnectType
        /// </summary>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public DisconnectTypeEnum? DisconnectType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SocialExpression" />class.
        /// </summary>
        /// <param name="State">State.</param>
        /// <param name="Id">Id.</param>
        /// <param name="SocialMediaId">SocialMediaId.</param>
        /// <param name="SocialMediaHub">SocialMediaHub.</param>
        /// <param name="SocialUserName">SocialUserName.</param>
        /// <param name="PreviewText">PreviewText.</param>
        /// <param name="RecordingId">RecordingId.</param>
        /// <param name="Segments">Segments.</param>
        /// <param name="Held">Held (default to false).</param>
        /// <param name="DisconnectType">DisconnectType.</param>
        /// <param name="StartHoldTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="ConnectedTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DisconnectedTime">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>

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
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets SocialMediaId
        /// </summary>
        [DataMember(Name="socialMediaId", EmitDefaultValue=false)]
        public string SocialMediaId { get; set; }
    
        /// <summary>
        /// Gets or Sets SocialMediaHub
        /// </summary>
        [DataMember(Name="socialMediaHub", EmitDefaultValue=false)]
        public string SocialMediaHub { get; set; }
    
        /// <summary>
        /// Gets or Sets SocialUserName
        /// </summary>
        [DataMember(Name="socialUserName", EmitDefaultValue=false)]
        public string SocialUserName { get; set; }
    
        /// <summary>
        /// Gets or Sets PreviewText
        /// </summary>
        [DataMember(Name="previewText", EmitDefaultValue=false)]
        public string PreviewText { get; set; }
    
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
        /// Gets or Sets Held
        /// </summary>
        [DataMember(Name="held", EmitDefaultValue=false)]
        public bool? Held { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="startHoldTime", EmitDefaultValue=false)]
        public DateTime? StartHoldTime { get; set; }
    
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
