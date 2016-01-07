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
    public class PolicyConditions :  IEquatable<PolicyConditions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PolicyConditions" /> class.
        /// </summary>
        public PolicyConditions()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets ForUsers
        /// </summary>
        [DataMember(Name="forUsers", EmitDefaultValue=false)]
        public List<User> ForUsers { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Directions
        /// </summary>
        [DataMember(Name="directions", EmitDefaultValue=false)]
        public List<string> Directions { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DateRanges
        /// </summary>
        [DataMember(Name="dateRanges", EmitDefaultValue=false)]
        public List<string> DateRanges { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MediaTypes
        /// </summary>
        [DataMember(Name="mediaTypes", EmitDefaultValue=false)]
        public List<string> MediaTypes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ForQueues
        /// </summary>
        [DataMember(Name="forQueues", EmitDefaultValue=false)]
        public List<Queue> ForQueues { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Duration
        /// </summary>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public DurationCondition Duration { get; set; }
  
        
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PolicyConditions {\n");
            sb.Append("  ForUsers: ").Append(ForUsers).Append("\n");
            sb.Append("  Directions: ").Append(Directions).Append("\n");
            sb.Append("  DateRanges: ").Append(DateRanges).Append("\n");
            sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
            sb.Append("  ForQueues: ").Append(ForQueues).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  WrapupCodes: ").Append(WrapupCodes).Append("\n");
            sb.Append("  TimeAllowed: ").Append(TimeAllowed).Append("\n");
            
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
            return this.Equals(obj as PolicyConditions);
        }

        /// <summary>
        /// Returns true if PolicyConditions instances are equal
        /// </summary>
        /// <param name="obj">Instance of PolicyConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PolicyConditions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ForUsers == other.ForUsers ||
                    this.ForUsers != null &&
                    this.ForUsers.SequenceEqual(other.ForUsers)
                ) && 
                (
                    this.Directions == other.Directions ||
                    this.Directions != null &&
                    this.Directions.SequenceEqual(other.Directions)
                ) && 
                (
                    this.DateRanges == other.DateRanges ||
                    this.DateRanges != null &&
                    this.DateRanges.SequenceEqual(other.DateRanges)
                ) && 
                (
                    this.MediaTypes == other.MediaTypes ||
                    this.MediaTypes != null &&
                    this.MediaTypes.SequenceEqual(other.MediaTypes)
                ) && 
                (
                    this.ForQueues == other.ForQueues ||
                    this.ForQueues != null &&
                    this.ForQueues.SequenceEqual(other.ForQueues)
                ) && 
                (
                    this.Duration == other.Duration ||
                    this.Duration != null &&
                    this.Duration.Equals(other.Duration)
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
                    hash = hash * 57 + this.ForUsers.GetHashCode();
                
                if (this.Directions != null)
                    hash = hash * 57 + this.Directions.GetHashCode();
                
                if (this.DateRanges != null)
                    hash = hash * 57 + this.DateRanges.GetHashCode();
                
                if (this.MediaTypes != null)
                    hash = hash * 57 + this.MediaTypes.GetHashCode();
                
                if (this.ForQueues != null)
                    hash = hash * 57 + this.ForQueues.GetHashCode();
                
                if (this.Duration != null)
                    hash = hash * 57 + this.Duration.GetHashCode();
                
                if (this.WrapupCodes != null)
                    hash = hash * 57 + this.WrapupCodes.GetHashCode();
                
                if (this.TimeAllowed != null)
                    hash = hash * 57 + this.TimeAllowed.GetHashCode();
                
                return hash;
            }
        }

    }


}