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
    public class PINConfiguration :  IEquatable<PINConfiguration>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PINConfiguration" /> class.
        /// </summary>
        public PINConfiguration()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets MinimumLength
        /// </summary>
        [DataMember(Name="minimumLength", EmitDefaultValue=false)]
        public int? MinimumLength { get; set; }
  
        
        /// <summary>
        /// Gets or Sets MaximumLength
        /// </summary>
        [DataMember(Name="maximumLength", EmitDefaultValue=false)]
        public int? MaximumLength { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PINConfiguration {\n");
            sb.Append("  MinimumLength: ").Append(MinimumLength).Append("\n");
            sb.Append("  MaximumLength: ").Append(MaximumLength).Append("\n");
            
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
            return this.Equals(obj as PINConfiguration);
        }

        /// <summary>
        /// Returns true if PINConfiguration instances are equal
        /// </summary>
        /// <param name="obj">Instance of PINConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PINConfiguration other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MinimumLength == other.MinimumLength ||
                    this.MinimumLength != null &&
                    this.MinimumLength.Equals(other.MinimumLength)
                ) && 
                (
                    this.MaximumLength == other.MaximumLength ||
                    this.MaximumLength != null &&
                    this.MaximumLength.Equals(other.MaximumLength)
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
                
                if (this.MinimumLength != null)
                    hash = hash * 57 + this.MinimumLength.GetHashCode();
                
                if (this.MaximumLength != null)
                    hash = hash * 57 + this.MaximumLength.GetHashCode();
                
                return hash;
            }
        }

    }


}