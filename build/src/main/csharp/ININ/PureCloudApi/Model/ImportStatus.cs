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
    public partial class ImportStatus :  IEquatable<ImportStatus>
    { 
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum {
            
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            
            [EnumMember(Value = "FAILED")]
            Failed
        }
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ImportStatus" />class.
        /// </summary>
        /// <param name="State">State.</param>
        /// <param name="TotalRecords">TotalRecords.</param>
        /// <param name="CompletedRecords">CompletedRecords.</param>
        /// <param name="PercentComplete">PercentComplete.</param>
        /// <param name="FailureReason">FailureReason.</param>

        public ImportStatus(StateEnum? State = null, long? TotalRecords = null, long? CompletedRecords = null, int? PercentComplete = null, string FailureReason = null)
        {
            this.State = State;
            this.TotalRecords = TotalRecords;
            this.CompletedRecords = CompletedRecords;
            this.PercentComplete = PercentComplete;
            this.FailureReason = FailureReason;
            
        }
        
    
        /// <summary>
        /// Gets or Sets TotalRecords
        /// </summary>
        [DataMember(Name="totalRecords", EmitDefaultValue=false)]
        public long? TotalRecords { get; set; }
    
        /// <summary>
        /// Gets or Sets CompletedRecords
        /// </summary>
        [DataMember(Name="completedRecords", EmitDefaultValue=false)]
        public long? CompletedRecords { get; set; }
    
        /// <summary>
        /// Gets or Sets PercentComplete
        /// </summary>
        [DataMember(Name="percentComplete", EmitDefaultValue=false)]
        public int? PercentComplete { get; set; }
    
        /// <summary>
        /// Gets or Sets FailureReason
        /// </summary>
        [DataMember(Name="failureReason", EmitDefaultValue=false)]
        public string FailureReason { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportStatus {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TotalRecords: ").Append(TotalRecords).Append("\n");
            sb.Append("  CompletedRecords: ").Append(CompletedRecords).Append("\n");
            sb.Append("  PercentComplete: ").Append(PercentComplete).Append("\n");
            sb.Append("  FailureReason: ").Append(FailureReason).Append("\n");
            
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
            return this.Equals(obj as ImportStatus);
        }

        /// <summary>
        /// Returns true if ImportStatus instances are equal
        /// </summary>
        /// <param name="other">Instance of ImportStatus to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImportStatus other)
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
                    this.TotalRecords == other.TotalRecords ||
                    this.TotalRecords != null &&
                    this.TotalRecords.Equals(other.TotalRecords)
                ) &&
                (
                    this.CompletedRecords == other.CompletedRecords ||
                    this.CompletedRecords != null &&
                    this.CompletedRecords.Equals(other.CompletedRecords)
                ) &&
                (
                    this.PercentComplete == other.PercentComplete ||
                    this.PercentComplete != null &&
                    this.PercentComplete.Equals(other.PercentComplete)
                ) &&
                (
                    this.FailureReason == other.FailureReason ||
                    this.FailureReason != null &&
                    this.FailureReason.Equals(other.FailureReason)
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
                
                if (this.TotalRecords != null)
                    hash = hash * 59 + this.TotalRecords.GetHashCode();
                
                if (this.CompletedRecords != null)
                    hash = hash * 59 + this.CompletedRecords.GetHashCode();
                
                if (this.PercentComplete != null)
                    hash = hash * 59 + this.PercentComplete.GetHashCode();
                
                if (this.FailureReason != null)
                    hash = hash * 59 + this.FailureReason.GetHashCode();
                
                return hash;
            }
        }

    }
}
