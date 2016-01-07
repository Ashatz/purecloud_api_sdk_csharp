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
    public class Call :  IEquatable<Call>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Call" /> class.
        /// </summary>
        public Call()
        {
            this.Recording = false;
            this.Muted = false;
            this.Confined = false;
            this.Held = false;
            
        }

        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Direction
        /// </summary>
        [DataMember(Name="direction", EmitDefaultValue=false)]
        public string Direction { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Recording
        /// </summary>
        [DataMember(Name="recording", EmitDefaultValue=false)]
        public bool? Recording { get; set; }
  
        
        /// <summary>
        /// Gets or Sets RecordingState
        /// </summary>
        [DataMember(Name="recordingState", EmitDefaultValue=false)]
        public string RecordingState { get; set; }
  
        
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
        /// Gets or Sets DisconnectType
        /// </summary>
        [DataMember(Name="disconnectType", EmitDefaultValue=false)]
        public string DisconnectType { get; set; }
  
        
        /// <summary>
        /// Gets or Sets StartHoldTime
        /// </summary>
        [DataMember(Name="startHoldTime", EmitDefaultValue=false)]
        public DateTime? StartHoldTime { get; set; }
  
        
  
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
        /// <param name="obj">Instance of Call to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Call other)
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
                    hash = hash * 57 + this.State.GetHashCode();
                
                if (this.Id != null)
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Direction != null)
                    hash = hash * 57 + this.Direction.GetHashCode();
                
                if (this.Recording != null)
                    hash = hash * 57 + this.Recording.GetHashCode();
                
                if (this.RecordingState != null)
                    hash = hash * 57 + this.RecordingState.GetHashCode();
                
                if (this.Muted != null)
                    hash = hash * 57 + this.Muted.GetHashCode();
                
                if (this.Confined != null)
                    hash = hash * 57 + this.Confined.GetHashCode();
                
                if (this.Held != null)
                    hash = hash * 57 + this.Held.GetHashCode();
                
                if (this.RecordingId != null)
                    hash = hash * 57 + this.RecordingId.GetHashCode();
                
                if (this.Segments != null)
                    hash = hash * 57 + this.Segments.GetHashCode();
                
                if (this.ErrorInfo != null)
                    hash = hash * 57 + this.ErrorInfo.GetHashCode();
                
                if (this.DisconnectType != null)
                    hash = hash * 57 + this.DisconnectType.GetHashCode();
                
                if (this.StartHoldTime != null)
                    hash = hash * 57 + this.StartHoldTime.GetHashCode();
                
                return hash;
            }
        }

    }


}
