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
    public partial class ParticipantRequest :  IEquatable<ParticipantRequest>
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
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ParticipantRequest" />class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Wrapup">Wrapup.</param>
        /// <param name="State">State.</param>
        /// <param name="Recording">Recording (default to false).</param>
        /// <param name="Muted">Muted (default to false).</param>
        /// <param name="Confined">Confined (default to false).</param>
        /// <param name="Held">Held (default to false).</param>
        /// <param name="WrapupSkipped">WrapupSkipped (default to false).</param>

        public ParticipantRequest(string Id = null, Wrapup Wrapup = null, StateEnum? State = null, bool? Recording = null, bool? Muted = null, bool? Confined = null, bool? Held = null, bool? WrapupSkipped = null)
        {
            this.Id = Id;
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
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
    
        /// <summary>
        /// Gets or Sets Wrapup
        /// </summary>
        [DataMember(Name="wrapup", EmitDefaultValue=false)]
        public Wrapup Wrapup { get; set; }
    
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
        /// Gets or Sets WrapupSkipped
        /// </summary>
        [DataMember(Name="wrapupSkipped", EmitDefaultValue=false)]
        public bool? WrapupSkipped { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ParticipantRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(obj as ParticipantRequest);
        }

        /// <summary>
        /// Returns true if ParticipantRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of ParticipantRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ParticipantRequest other)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
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
