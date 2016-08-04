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
    /// CallMediaPolicyConditions
    /// </summary>
    [DataContract]
    public partial class CallMediaPolicyConditions :  IEquatable<CallMediaPolicyConditions>
    {
        /// <summary>
        /// Gets or Sets Directions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DirectionsEnum
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
        /// Initializes a new instance of the <see cref="CallMediaPolicyConditions" /> class.
        /// </summary>
        /// <param name="ForUsers">ForUsers.</param>
        /// <param name="DateRanges">DateRanges.</param>
        /// <param name="ForQueues">ForQueues.</param>
        /// <param name="WrapupCodes">WrapupCodes.</param>
        /// <param name="TimeAllowed">TimeAllowed.</param>
        /// <param name="Directions">Directions.</param>
        /// <param name="Duration">Duration.</param>
        public CallMediaPolicyConditions(List<User> ForUsers = null, List<string> DateRanges = null, List<Queue> ForQueues = null, List<WrapupCode> WrapupCodes = null, TimeAllowed TimeAllowed = null, List<DirectionsEnum> Directions = null, DurationCondition Duration = null)
        {
            this.ForUsers = ForUsers;
            this.DateRanges = DateRanges;
            this.ForQueues = ForQueues;
            this.WrapupCodes = WrapupCodes;
            this.TimeAllowed = TimeAllowed;
            this.Directions = Directions;
            this.Duration = Duration;
        }
        
        /// <summary>
        /// Gets or Sets ForUsers
        /// </summary>
        [DataMember(Name="forUsers", EmitDefaultValue=false)]
        public List<User> ForUsers { get; set; }
        /// <summary>
        /// Gets or Sets DateRanges
        /// </summary>
        [DataMember(Name="dateRanges", EmitDefaultValue=false)]
        public List<string> DateRanges { get; set; }
        /// <summary>
        /// Gets or Sets ForQueues
        /// </summary>
        [DataMember(Name="forQueues", EmitDefaultValue=false)]
        public List<Queue> ForQueues { get; set; }
        /// <summary>
        /// Gets or Sets WrapupCodes
        /// </summary>
        [DataMember(Name="wrapupCodes", EmitDefaultValue=false)]
        public List<WrapupCode> WrapupCodes { get; set; }
        /// <summary>
        /// Gets or Sets TimeAllowed
        /// </summary>
        [DataMember(Name="timeAllowed", EmitDefaultValue=false)]
        public TimeAllowed TimeAllowed { get; set; }
        /// <summary>
        /// Gets or Sets Directions
        /// </summary>
        [DataMember(Name="directions", EmitDefaultValue=false)]
        public List<DirectionsEnum> Directions { get; set; }
        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public DurationCondition Duration { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallMediaPolicyConditions {\n");
            sb.Append("  ForUsers: ").Append(ForUsers).Append("\n");
            sb.Append("  DateRanges: ").Append(DateRanges).Append("\n");
            sb.Append("  ForQueues: ").Append(ForQueues).Append("\n");
            sb.Append("  WrapupCodes: ").Append(WrapupCodes).Append("\n");
            sb.Append("  TimeAllowed: ").Append(TimeAllowed).Append("\n");
            sb.Append("  Directions: ").Append(Directions).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
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
            return this.Equals(obj as CallMediaPolicyConditions);
        }

        /// <summary>
        /// Returns true if CallMediaPolicyConditions instances are equal
        /// </summary>
        /// <param name="other">Instance of CallMediaPolicyConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallMediaPolicyConditions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.ForUsers == other.ForUsers ||
                    this.ForUsers != null &&
                    this.ForUsers.SequenceEqual(other.ForUsers)
                ) &&
                (
                    this.DateRanges == other.DateRanges ||
                    this.DateRanges != null &&
                    this.DateRanges.SequenceEqual(other.DateRanges)
                ) &&
                (
                    this.ForQueues == other.ForQueues ||
                    this.ForQueues != null &&
                    this.ForQueues.SequenceEqual(other.ForQueues)
                ) &&
                (
                    this.WrapupCodes == other.WrapupCodes ||
                    this.WrapupCodes != null &&
                    this.WrapupCodes.SequenceEqual(other.WrapupCodes)
                ) &&
                (
                    this.TimeAllowed == other.TimeAllowed ||
                    this.TimeAllowed != null &&
                    this.TimeAllowed.Equals(other.TimeAllowed)
                ) &&
                (
                    this.Directions == other.Directions ||
                    this.Directions != null &&
                    this.Directions.SequenceEqual(other.Directions)
                ) &&
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
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
                if (this.ForUsers != null)
                    hash = hash * 59 + this.ForUsers.GetHashCode();
                if (this.DateRanges != null)
                    hash = hash * 59 + this.DateRanges.GetHashCode();
                if (this.ForQueues != null)
                    hash = hash * 59 + this.ForQueues.GetHashCode();
                if (this.WrapupCodes != null)
                    hash = hash * 59 + this.WrapupCodes.GetHashCode();
                if (this.TimeAllowed != null)
                    hash = hash * 59 + this.TimeAllowed.GetHashCode();
                if (this.Directions != null)
                    hash = hash * 59 + this.Directions.GetHashCode();
                if (this.Duration != null)
                    hash = hash * 59 + this.Duration.GetHashCode();
                return hash;
            }
        }
    }

}
