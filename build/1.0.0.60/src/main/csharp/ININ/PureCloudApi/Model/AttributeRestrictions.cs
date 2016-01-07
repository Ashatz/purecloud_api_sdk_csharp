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
    public class AttributeRestrictions :  IEquatable<AttributeRestrictions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttributeRestrictions" /> class.
        /// </summary>
        public AttributeRestrictions()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name="date", EmitDefaultValue=false)]
        public DateDefinition Date { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name="number", EmitDefaultValue=false)]
        public NumberDefinition Number { get; set; }
  
        
        /// <summary>
        /// Gets or Sets String
        /// </summary>
        [DataMember(Name="string", EmitDefaultValue=false)]
        public StringDefinition String { get; set; }
  
        
        /// <summary>
        /// Gets or Sets List
        /// </summary>
        [DataMember(Name="list", EmitDefaultValue=false)]
        public ListDefinition List { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttributeRestrictions {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  String: ").Append(String).Append("\n");
            sb.Append("  List: ").Append(List).Append("\n");
            
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
            return this.Equals(obj as AttributeRestrictions);
        }

        /// <summary>
        /// Returns true if AttributeRestrictions instances are equal
        /// </summary>
        /// <param name="obj">Instance of AttributeRestrictions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttributeRestrictions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Date == other.Date ||
                    this.Date != null &&
                    this.Date.Equals(other.Date)
                ) && 
                (
                    this.Number == other.Number ||
                    this.Number != null &&
                    this.Number.Equals(other.Number)
                ) && 
                (
                    this.String == other.String ||
                    this.String != null &&
                    this.String.Equals(other.String)
                ) && 
                (
                    this.List == other.List ||
                    this.List != null &&
                    this.List.Equals(other.List)
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
                
                if (this.Date != null)
                    hash = hash * 57 + this.Date.GetHashCode();
                
                if (this.Number != null)
                    hash = hash * 57 + this.Number.GetHashCode();
                
                if (this.String != null)
                    hash = hash * 57 + this.String.GetHashCode();
                
                if (this.List != null)
                    hash = hash * 57 + this.List.GetHashCode();
                
                return hash;
            }
        }

    }


}
