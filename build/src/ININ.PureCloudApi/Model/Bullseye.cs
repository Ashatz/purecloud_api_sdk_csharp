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
    /// Bullseye
    /// </summary>
    [DataContract]
    public partial class Bullseye :  IEquatable<Bullseye>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Bullseye" /> class.
        /// </summary>
        /// <param name="Rings">Rings.</param>
        public Bullseye(List<Ring> Rings = null)
        {
            this.Rings = Rings;
        }
        
        /// <summary>
        /// Gets or Sets Rings
        /// </summary>
        [DataMember(Name="rings", EmitDefaultValue=false)]
        public List<Ring> Rings { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bullseye {\n");
            sb.Append("  Rings: ").Append(Rings).Append("\n");
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
            return this.Equals(obj as Bullseye);
        }

        /// <summary>
        /// Returns true if Bullseye instances are equal
        /// </summary>
        /// <param name="other">Instance of Bullseye to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bullseye other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Rings == other.Rings ||
                    this.Rings != null &&
                    this.Rings.SequenceEqual(other.Rings)
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
                if (this.Rings != null)
                    hash = hash * 59 + this.Rings.GetHashCode();
                return hash;
            }
        }
    }

}
