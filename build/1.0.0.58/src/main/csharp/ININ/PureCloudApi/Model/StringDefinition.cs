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
    public class StringDefinition :  IEquatable<StringDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StringDefinition" /> class.
        /// </summary>
        public StringDefinition()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
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
        /// Gets or Sets RegularExpression
        /// </summary>
        [DataMember(Name="regularExpression", EmitDefaultValue=false)]
        public string RegularExpression { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StringDefinition {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  MinimumLength: ").Append(MinimumLength).Append("\n");
            sb.Append("  MaximumLength: ").Append(MaximumLength).Append("\n");
            sb.Append("  RegularExpression: ").Append(RegularExpression).Append("\n");
            
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
            return this.Equals(obj as StringDefinition);
        }

        /// <summary>
        /// Returns true if StringDefinition instances are equal
        /// </summary>
        /// <param name="obj">Instance of StringDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StringDefinition other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.MinimumLength == other.MinimumLength ||
                    this.MinimumLength != null &&
                    this.MinimumLength.Equals(other.MinimumLength)
                ) && 
                (
                    this.MaximumLength == other.MaximumLength ||
                    this.MaximumLength != null &&
                    this.MaximumLength.Equals(other.MaximumLength)
                ) && 
                (
                    this.RegularExpression == other.RegularExpression ||
                    this.RegularExpression != null &&
                    this.RegularExpression.Equals(other.RegularExpression)
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
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.MinimumLength != null)
                    hash = hash * 57 + this.MinimumLength.GetHashCode();
                
                if (this.MaximumLength != null)
                    hash = hash * 57 + this.MaximumLength.GetHashCode();
                
                if (this.RegularExpression != null)
                    hash = hash * 57 + this.RegularExpression.GetHashCode();
                
                return hash;
            }
        }

    }


}
