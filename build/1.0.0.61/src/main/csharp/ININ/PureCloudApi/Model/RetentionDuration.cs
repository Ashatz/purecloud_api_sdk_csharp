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
    public class RetentionDuration :  IEquatable<RetentionDuration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RetentionDuration" /> class.
        /// </summary>
        public RetentionDuration()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets ArchiveRetention
        /// </summary>
        [DataMember(Name="archiveRetention", EmitDefaultValue=false)]
        public ArchiveRetention ArchiveRetention { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DeleteRetention
        /// </summary>
        [DataMember(Name="deleteRetention", EmitDefaultValue=false)]
        public DeleteRetention DeleteRetention { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RetentionDuration {\n");
            sb.Append("  ArchiveRetention: ").Append(ArchiveRetention).Append("\n");
            sb.Append("  DeleteRetention: ").Append(DeleteRetention).Append("\n");
            
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
            return this.Equals(obj as RetentionDuration);
        }

        /// <summary>
        /// Returns true if RetentionDuration instances are equal
        /// </summary>
        /// <param name="obj">Instance of RetentionDuration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RetentionDuration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ArchiveRetention == other.ArchiveRetention ||
                    this.ArchiveRetention != null &&
                    this.ArchiveRetention.Equals(other.ArchiveRetention)
                ) && 
                (
                    this.DeleteRetention == other.DeleteRetention ||
                    this.DeleteRetention != null &&
                    this.DeleteRetention.Equals(other.DeleteRetention)
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
                
                if (this.ArchiveRetention != null)
                    hash = hash * 57 + this.ArchiveRetention.GetHashCode();
                
                if (this.DeleteRetention != null)
                    hash = hash * 57 + this.DeleteRetention.GetHashCode();
                
                return hash;
            }
        }

    }


}
