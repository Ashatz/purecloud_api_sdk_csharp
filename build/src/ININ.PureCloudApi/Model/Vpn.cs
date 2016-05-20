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
    /// Vpn
    /// </summary>
    [DataContract]
    public partial class Vpn :  IEquatable<Vpn>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Vpn" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Ip">Ip.</param>
        /// <param name="Psk">Psk.</param>
        public Vpn(string Type = null, string Ip = null, string Psk = null)
        {
            this.Type = Type;
            this.Ip = Ip;
            this.Psk = Psk;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Ip
        /// </summary>
        [DataMember(Name="ip", EmitDefaultValue=false)]
        public string Ip { get; set; }
        /// <summary>
        /// Gets or Sets Psk
        /// </summary>
        [DataMember(Name="psk", EmitDefaultValue=false)]
        public string Psk { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Vpn {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Ip: ").Append(Ip).Append("\n");
            sb.Append("  Psk: ").Append(Psk).Append("\n");
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
            return this.Equals(obj as Vpn);
        }

        /// <summary>
        /// Returns true if Vpn instances are equal
        /// </summary>
        /// <param name="other">Instance of Vpn to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Vpn other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Ip == other.Ip ||
                    this.Ip != null &&
                    this.Ip.Equals(other.Ip)
                ) &&
                (
                    this.Psk == other.Psk ||
                    this.Psk != null &&
                    this.Psk.Equals(other.Psk)
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
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Ip != null)
                    hash = hash * 59 + this.Ip.GetHashCode();
                if (this.Psk != null)
                    hash = hash * 59 + this.Psk.GetHashCode();
                return hash;
            }
        }
    }

}
