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
    /// BillingAddress
    /// </summary>
    [DataContract]
    public partial class BillingAddress :  IEquatable<BillingAddress>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAddress" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Street">Street.</param>
        /// <param name="City">City.</param>
        /// <param name="CountryName">CountryName.</param>
        /// <param name="StateName">StateName.</param>
        /// <param name="PostalCode">PostalCode.</param>
        public BillingAddress(, string Name = null, string Street = null, string City = null, string CountryName = null, string StateName = null, string PostalCode = null)
        {
            this.Name = Name;
            this.Street = Street;
            this.City = City;
            this.CountryName = CountryName;
            this.StateName = StateName;
            this.PostalCode = PostalCode;
        }
        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Street
        /// </summary>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// Gets or Sets CountryName
        /// </summary>
        [DataMember(Name="countryName", EmitDefaultValue=false)]
        public string CountryName { get; set; }
        /// <summary>
        /// Gets or Sets StateName
        /// </summary>
        [DataMember(Name="stateName", EmitDefaultValue=false)]
        public string StateName { get; set; }
        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
        /// <summary>
        /// The URI for this object
        /// </summary>
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingAddress {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  StateName: ").Append(StateName).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
            return this.Equals(obj as BillingAddress);
        }

        /// <summary>
        /// Returns true if BillingAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Street == other.Street ||
                    this.Street != null &&
                    this.Street.Equals(other.Street)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.CountryName == other.CountryName ||
                    this.CountryName != null &&
                    this.CountryName.Equals(other.CountryName)
                ) && 
                (
                    this.StateName == other.StateName ||
                    this.StateName != null &&
                    this.StateName.Equals(other.StateName)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                )
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Street != null)
                    hash = hash * 59 + this.Street.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.CountryName != null)
                    hash = hash * 59 + this.CountryName.GetHashCode();
                if (this.StateName != null)
                    hash = hash * 59 + this.StateName.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
