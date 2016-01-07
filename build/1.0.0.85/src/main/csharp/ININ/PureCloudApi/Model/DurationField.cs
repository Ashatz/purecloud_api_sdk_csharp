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
    public class DurationField :  IEquatable<DurationField>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DurationField" /> class.
        /// </summary>
        public DurationField()
        {
            this.Precise = false;
            this.Supported = false;
            
        }

        
        /// <summary>
        /// Gets or Sets Precise
        /// </summary>
        [DataMember(Name="precise", EmitDefaultValue=false)]
        public bool? Precise { get; set; }
  
        
        /// <summary>
        /// Gets or Sets UnitMillis
        /// </summary>
        [DataMember(Name="unitMillis", EmitDefaultValue=false)]
        public long? UnitMillis { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public DurationFieldType Type { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Supported
        /// </summary>
        [DataMember(Name="supported", EmitDefaultValue=false)]
        public bool? Supported { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DurationField {\n");
            sb.Append("  Precise: ").Append(Precise).Append("\n");
            sb.Append("  UnitMillis: ").Append(UnitMillis).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Supported: ").Append(Supported).Append("\n");
            
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
            return this.Equals(obj as DurationField);
        }

        /// <summary>
        /// Returns true if DurationField instances are equal
        /// </summary>
        /// <param name="obj">Instance of DurationField to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DurationField other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Precise == other.Precise ||
                    this.Precise != null &&
                    this.Precise.Equals(other.Precise)
                ) && 
                (
                    this.UnitMillis == other.UnitMillis ||
                    this.UnitMillis != null &&
                    this.UnitMillis.Equals(other.UnitMillis)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Supported == other.Supported ||
                    this.Supported != null &&
                    this.Supported.Equals(other.Supported)
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
                
                if (this.Precise != null)
                    hash = hash * 57 + this.Precise.GetHashCode();
                
                if (this.UnitMillis != null)
                    hash = hash * 57 + this.UnitMillis.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.Supported != null)
                    hash = hash * 57 + this.Supported.GetHashCode();
                
                return hash;
            }
        }

    }


}
