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
    /// PortBillingAddress
    /// </summary>
    [DataContract]
    public partial class PortBillingAddress :  IEquatable<PortBillingAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PortBillingAddress" /> class.
        /// </summary>
        /// <param name="StreetAddress">StreetAddress.</param>
        /// <param name="CityProvince">CityProvince.</param>
        /// <param name="State">State.</param>
        /// <param name="ZipPostal">ZipPostal.</param>
        /// <param name="Country">Country.</param>
        public PortBillingAddress(string StreetAddress = null, string CityProvince = null, string State = null, string ZipPostal = null, string Country = null)
        {
            this.StreetAddress = StreetAddress;
            this.CityProvince = CityProvince;
            this.State = State;
            this.ZipPostal = ZipPostal;
            this.Country = Country;
        }
        
        /// <summary>
        /// Gets or Sets StreetAddress
        /// </summary>
        [DataMember(Name="streetAddress", EmitDefaultValue=false)]
        public string StreetAddress { get; set; }
        /// <summary>
        /// Gets or Sets CityProvince
        /// </summary>
        [DataMember(Name="cityProvince", EmitDefaultValue=false)]
        public string CityProvince { get; set; }
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
        /// <summary>
        /// Gets or Sets ZipPostal
        /// </summary>
        [DataMember(Name="zipPostal", EmitDefaultValue=false)]
        public string ZipPostal { get; set; }
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PortBillingAddress {\n");
            sb.Append("  StreetAddress: ").Append(StreetAddress).Append("\n");
            sb.Append("  CityProvince: ").Append(CityProvince).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ZipPostal: ").Append(ZipPostal).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(obj as PortBillingAddress);
        }

        /// <summary>
        /// Returns true if PortBillingAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of PortBillingAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PortBillingAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.StreetAddress == other.StreetAddress ||
                    this.StreetAddress != null &&
                    this.StreetAddress.Equals(other.StreetAddress)
                ) &&
                (
                    this.CityProvince == other.CityProvince ||
                    this.CityProvince != null &&
                    this.CityProvince.Equals(other.CityProvince)
                ) &&
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) &&
                (
                    this.ZipPostal == other.ZipPostal ||
                    this.ZipPostal != null &&
                    this.ZipPostal.Equals(other.ZipPostal)
                ) &&
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
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
                if (this.StreetAddress != null)
                    hash = hash * 59 + this.StreetAddress.GetHashCode();
                if (this.CityProvince != null)
                    hash = hash * 59 + this.CityProvince.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.ZipPostal != null)
                    hash = hash * 59 + this.ZipPostal.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                return hash;
            }
        }
    }

}
