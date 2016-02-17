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
    public class SocializeEntityFilter :  IEquatable<SocializeEntityFilter>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SocializeEntityFilter" /> class.
        /// </summary>
        public SocializeEntityFilter()
        {
            
        }

        
        /// <summary>
        /// The fieldName the filter will be applied to.
        /// </summary>
        /// <value>The fieldName the filter will be applied to.</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }
  
        
        /// <summary>
        /// The operator to apply when filtering.
        /// </summary>
        /// <value>The operator to apply when filtering.</value>
        [DataMember(Name="operator", EmitDefaultValue=false)]
        public string Operator { get; set; }
  
        
        /// <summary>
        /// The value to filter on.
        /// </summary>
        /// <value>The value to filter on.</value>
        [DataMember(Name="fieldValue", EmitDefaultValue=false)]
        public string FieldValue { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SocializeEntityFilter {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  FieldValue: ").Append(FieldValue).Append("\n");
            
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
            return this.Equals(obj as SocializeEntityFilter);
        }

        /// <summary>
        /// Returns true if SocializeEntityFilter instances are equal
        /// </summary>
        /// <param name="obj">Instance of SocializeEntityFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SocializeEntityFilter other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.FieldName == other.FieldName ||
                    this.FieldName != null &&
                    this.FieldName.Equals(other.FieldName)
                ) && 
                (
                    this.Operator == other.Operator ||
                    this.Operator != null &&
                    this.Operator.Equals(other.Operator)
                ) && 
                (
                    this.FieldValue == other.FieldValue ||
                    this.FieldValue != null &&
                    this.FieldValue.Equals(other.FieldValue)
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
                
                if (this.FieldName != null)
                    hash = hash * 57 + this.FieldName.GetHashCode();
                
                if (this.Operator != null)
                    hash = hash * 57 + this.Operator.GetHashCode();
                
                if (this.FieldValue != null)
                    hash = hash * 57 + this.FieldValue.GetHashCode();
                
                return hash;
            }
        }

    }


}
