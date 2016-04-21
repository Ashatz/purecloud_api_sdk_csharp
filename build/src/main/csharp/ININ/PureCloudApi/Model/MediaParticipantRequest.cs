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
    public partial class MediaParticipantRequest :  IEquatable<MediaParticipantRequest>
    { 

        /// <summary>
        /// The state to update to set for this participant's communications.  Possible values are: 'connected' and 'disconnected'.
        /// </summary>
        /// <value>The state to update to set for this participant's communications.  Possible values are: 'connected' and 'disconnected'.</value>
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
        /// The state to update to set for this participant's communications.  Possible values are: 'connected' and 'disconnected'.
        /// </summary>
        /// <value>The state to update to set for this participant's communications.  Possible values are: 'connected' and 'disconnected'.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MediaParticipantRequest" />class.
        /// </summary>
        /// <param name="Wrapup">Wrap-up to assign to this participant..</param>
        /// <param name="State">The state to update to set for this participant&#39;s communications.  Possible values are: &#39;connected&#39; and &#39;disconnected&#39;..</param>
        /// <param name="Recording">True to enable recording of this participant, otherwise false to disable recording. (default to false).</param>
        /// <param name="Muted">True to mute this conversation participant. (default to false).</param>
        /// <param name="Confined">True to confine this conversation participant.  Should only be used for ad-hoc conferences (default to false).</param>
        /// <param name="Held">True to hold this conversation participant. (default to false).</param>
        /// <param name="WrapupSkipped">True to skip wrap-up for this participant. (default to false).</param>

        public MediaParticipantRequest(Wrapup Wrapup = null, StateEnum? State = null, bool? Recording = null, bool? Muted = null, bool? Confined = null, bool? Held = null, bool? WrapupSkipped = null)
        {
            this.Wrapup = Wrapup;
            this.State = State;
            // use default value if no "Recording" provided
            if (Recording == null)
            {
                this.Recording = false;
            }
            else
            {
                this.Recording = Recording;
            }
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
            // use default value if no "WrapupSkipped" provided
            if (WrapupSkipped == null)
            {
                this.WrapupSkipped = false;
            }
            else
            {
                this.WrapupSkipped = WrapupSkipped;
            }
            
        }

    
        /// <summary>
        /// Wrap-up to assign to this participant.
        /// </summary>
        /// <value>Wrap-up to assign to this participant.</value>
        [DataMember(Name="wrapup", EmitDefaultValue=false)]
        public Wrapup Wrapup { get; set; }
    
        /// <summary>
        /// True to enable recording of this participant, otherwise false to disable recording.
        /// </summary>
        /// <value>True to enable recording of this participant, otherwise false to disable recording.</value>
        [DataMember(Name="recording", EmitDefaultValue=false)]
        public bool? Recording { get; set; }
    
        /// <summary>
        /// True to mute this conversation participant.
        /// </summary>
        /// <value>True to mute this conversation participant.</value>
        [DataMember(Name="muted", EmitDefaultValue=false)]
        public bool? Muted { get; set; }
    
        /// <summary>
        /// True to confine this conversation participant.  Should only be used for ad-hoc conferences
        /// </summary>
        /// <value>True to confine this conversation participant.  Should only be used for ad-hoc conferences</value>
        [DataMember(Name="confined", EmitDefaultValue=false)]
        public bool? Confined { get; set; }
    
        /// <summary>
        /// True to hold this conversation participant.
        /// </summary>
        /// <value>True to hold this conversation participant.</value>
        [DataMember(Name="held", EmitDefaultValue=false)]
        public bool? Held { get; set; }
    
        /// <summary>
        /// True to skip wrap-up for this participant.
        /// </summary>
        /// <value>True to skip wrap-up for this participant.</value>
        [DataMember(Name="wrapupSkipped", EmitDefaultValue=false)]
        public bool? WrapupSkipped { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MediaParticipantRequest {\n");
            sb.Append("  Wrapup: ").Append(Wrapup).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Recording: ").Append(Recording).Append("\n");
            sb.Append("  Muted: ").Append(Muted).Append("\n");
            sb.Append("  Confined: ").Append(Confined).Append("\n");
            sb.Append("  Held: ").Append(Held).Append("\n");
            sb.Append("  WrapupSkipped: ").Append(WrapupSkipped).Append("\n");
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
            return this.Equals(obj as MediaParticipantRequest);
        }

        /// <summary>
        /// Returns true if MediaParticipantRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of MediaParticipantRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MediaParticipantRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Wrapup == other.Wrapup ||
                    this.Wrapup != null &&
                    this.Wrapup.Equals(other.Wrapup)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.Recording == other.Recording ||
                    this.Recording != null &&
                    this.Recording.Equals(other.Recording)
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
                    this.WrapupSkipped == other.WrapupSkipped ||
                    this.WrapupSkipped != null &&
                    this.WrapupSkipped.Equals(other.WrapupSkipped)
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
                if (this.Wrapup != null)
                    hash = hash * 59 + this.Wrapup.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.Recording != null)
                    hash = hash * 59 + this.Recording.GetHashCode();
                if (this.Muted != null)
                    hash = hash * 59 + this.Muted.GetHashCode();
                if (this.Confined != null)
                    hash = hash * 59 + this.Confined.GetHashCode();
                if (this.Held != null)
                    hash = hash * 59 + this.Held.GetHashCode();
                if (this.WrapupSkipped != null)
                    hash = hash * 59 + this.WrapupSkipped.GetHashCode();
                return hash;
            }
        }

    }
}
