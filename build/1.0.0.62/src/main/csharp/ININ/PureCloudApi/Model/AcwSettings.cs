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
    public class AcwSettings :  IEquatable<AcwSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AcwSettings" /> class.
        /// </summary>
        public AcwSettings()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets WrapupPrompt
        /// </summary>
        [DataMember(Name="wrapupPrompt", EmitDefaultValue=false)]
        public string WrapupPrompt { get; set; }
  
        
        /// <summary>
        /// Gets or Sets TimeoutMs
        /// </summary>
        [DataMember(Name="timeoutMs", EmitDefaultValue=false)]
        public int? TimeoutMs { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AcwSettings {\n");
            sb.Append("  WrapupPrompt: ").Append(WrapupPrompt).Append("\n");
            sb.Append("  TimeoutMs: ").Append(TimeoutMs).Append("\n");
            
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
            return this.Equals(obj as AcwSettings);
        }

        /// <summary>
        /// Returns true if AcwSettings instances are equal
        /// </summary>
        /// <param name="obj">Instance of AcwSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AcwSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WrapupPrompt == other.WrapupPrompt ||
                    this.WrapupPrompt != null &&
                    this.WrapupPrompt.Equals(other.WrapupPrompt)
                ) && 
                (
                    this.TimeoutMs == other.TimeoutMs ||
                    this.TimeoutMs != null &&
                    this.TimeoutMs.Equals(other.TimeoutMs)
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
                
                if (this.WrapupPrompt != null)
                    hash = hash * 57 + this.WrapupPrompt.GetHashCode();
                
                if (this.TimeoutMs != null)
                    hash = hash * 57 + this.TimeoutMs.GetHashCode();
                
                return hash;
            }
        }

    }


}
