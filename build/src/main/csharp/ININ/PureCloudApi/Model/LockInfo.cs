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
    public partial class LockInfo :  IEquatable<LockInfo>
    { 
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum {
            
            [EnumMember(Value = "UPDATE")]
            Update,
            
            [EnumMember(Value = "DELETE")]
            Delete,
            
            [EnumMember(Value = "COPY")]
            Copy,
            
            [EnumMember(Value = "MOVE")]
            Move,
            
            [EnumMember(Value = "REPLACE")]
            Replace,
            
            [EnumMember(Value = "THUMBNAIL")]
            Thumbnail,
            
            [EnumMember(Value = "TEXT_EXTRACTION")]
            TextExtraction
        }
        
        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name="action", EmitDefaultValue=false)]
        public ActionEnum? Action { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LockInfo" />class.
        /// </summary>
        /// <param name="LockedBy">LockedBy.</param>
        /// <param name="DateCreated">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DateExpires">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Action">Action.</param>

        public LockInfo(UriReference LockedBy = null, DateTime? DateCreated = null, DateTime? DateExpires = null, ActionEnum? Action = null)
        {
            this.LockedBy = LockedBy;
            this.DateCreated = DateCreated;
            this.DateExpires = DateExpires;
            this.Action = Action;
            
        }
        
    
        /// <summary>
        /// Gets or Sets LockedBy
        /// </summary>
        [DataMember(Name="lockedBy", EmitDefaultValue=false)]
        public UriReference LockedBy { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateCreated", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dateExpires", EmitDefaultValue=false)]
        public DateTime? DateExpires { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LockInfo {\n");
            sb.Append("  LockedBy: ").Append(LockedBy).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateExpires: ").Append(DateExpires).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            
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
            return this.Equals(obj as LockInfo);
        }

        /// <summary>
        /// Returns true if LockInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of LockInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LockInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.LockedBy == other.LockedBy ||
                    this.LockedBy != null &&
                    this.LockedBy.Equals(other.LockedBy)
                ) &&
                (
                    this.DateCreated == other.DateCreated ||
                    this.DateCreated != null &&
                    this.DateCreated.Equals(other.DateCreated)
                ) &&
                (
                    this.DateExpires == other.DateExpires ||
                    this.DateExpires != null &&
                    this.DateExpires.Equals(other.DateExpires)
                ) &&
                (
                    this.Action == other.Action ||
                    this.Action != null &&
                    this.Action.Equals(other.Action)
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
                
                if (this.LockedBy != null)
                    hash = hash * 59 + this.LockedBy.GetHashCode();
                
                if (this.DateCreated != null)
                    hash = hash * 59 + this.DateCreated.GetHashCode();
                
                if (this.DateExpires != null)
                    hash = hash * 59 + this.DateExpires.GetHashCode();
                
                if (this.Action != null)
                    hash = hash * 59 + this.Action.GetHashCode();
                
                return hash;
            }
        }

    }
}
