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
    /// DomainNetworkAddress
    /// </summary>
    [DataContract]
    public partial class DomainNetworkAddress :  IEquatable<DomainNetworkAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainNetworkAddress" /> class.
        /// </summary>
        /// <param name="Type">Type.</param>
        /// <param name="Address">Address.</param>
        /// <param name="Persistent">Persistent (default to false).</param>
        /// <param name="Family">Family.</param>
        public DomainNetworkAddress(string Type = null, string Address = null, bool? Persistent = null, int? Family = null)
        {
            this.Type = Type;
            this.Address = Address;
            // use default value if no "Persistent" provided
            if (Persistent == null)
            {
                this.Persistent = false;
            }
            else
            {
                this.Persistent = Persistent;
            }
            this.Family = Family;
        }
        
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
        /// <summary>
        /// Gets or Sets Persistent
        /// </summary>
        [DataMember(Name="persistent", EmitDefaultValue=false)]
        public bool? Persistent { get; set; }
        /// <summary>
        /// Gets or Sets Family
        /// </summary>
        [DataMember(Name="family", EmitDefaultValue=false)]
        public int? Family { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainNetworkAddress {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Persistent: ").Append(Persistent).Append("\n");
            sb.Append("  Family: ").Append(Family).Append("\n");
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
            return this.Equals(obj as DomainNetworkAddress);
        }

        /// <summary>
        /// Returns true if DomainNetworkAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of DomainNetworkAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainNetworkAddress other)
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
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.Persistent == other.Persistent ||
                    this.Persistent != null &&
                    this.Persistent.Equals(other.Persistent)
                ) &&
                (
                    this.Family == other.Family ||
                    this.Family != null &&
                    this.Family.Equals(other.Family)
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
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Persistent != null)
                    hash = hash * 59 + this.Persistent.GetHashCode();
                if (this.Family != null)
                    hash = hash * 59 + this.Family.GetHashCode();
                return hash;
            }
        }
    }

}
