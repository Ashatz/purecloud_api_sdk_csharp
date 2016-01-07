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
    public class CallRecord :  IEquatable<CallRecord>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CallRecord" /> class.
        /// </summary>
        public CallRecord()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets LastAttempt
        /// </summary>
        [DataMember(Name="lastAttempt", EmitDefaultValue=false)]
        public DateTime? LastAttempt { get; set; }
  
        
        /// <summary>
        /// Gets or Sets LastResult
        /// </summary>
        [DataMember(Name="lastResult", EmitDefaultValue=false)]
        public string LastResult { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CallRecord {\n");
            sb.Append("  LastAttempt: ").Append(LastAttempt).Append("\n");
            sb.Append("  LastResult: ").Append(LastResult).Append("\n");
            
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
            return this.Equals(obj as CallRecord);
        }

        /// <summary>
        /// Returns true if CallRecord instances are equal
        /// </summary>
        /// <param name="obj">Instance of CallRecord to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CallRecord other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LastAttempt == other.LastAttempt ||
                    this.LastAttempt != null &&
                    this.LastAttempt.Equals(other.LastAttempt)
                ) && 
                (
                    this.LastResult == other.LastResult ||
                    this.LastResult != null &&
                    this.LastResult.Equals(other.LastResult)
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
                
                if (this.LastAttempt != null)
                    hash = hash * 57 + this.LastAttempt.GetHashCode();
                
                if (this.LastResult != null)
                    hash = hash * 57 + this.LastResult.GetHashCode();
                
                return hash;
            }
        }

    }


}
