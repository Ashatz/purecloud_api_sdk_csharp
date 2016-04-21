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
    public partial class TransformLens :  IEquatable<TransformLens>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="TransformLens" />class.
        /// </summary>
        /// <param name="Replace">Replace.</param>
        /// <param name="Value">Value.</param>

        public TransformLens(string Replace = null, string Value = null)
        {
            this.Replace = Replace;
            this.Value = Value;
            
        }

    
        /// <summary>
        /// Gets or Sets Replace
        /// </summary>
        [DataMember(Name="replace", EmitDefaultValue=false)]
        public string Replace { get; set; }
    
        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransformLens {\n");
            sb.Append("  Replace: ").Append(Replace).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(obj as TransformLens);
        }

        /// <summary>
        /// Returns true if TransformLens instances are equal
        /// </summary>
        /// <param name="other">Instance of TransformLens to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransformLens other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Replace == other.Replace ||
                    this.Replace != null &&
                    this.Replace.Equals(other.Replace)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
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
                if (this.Replace != null)
                    hash = hash * 59 + this.Replace.GetHashCode();
                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();
                return hash;
            }
        }

    }
}
