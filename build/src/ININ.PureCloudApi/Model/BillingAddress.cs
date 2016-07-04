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
        [JsonConstructorAttribute]
        protected BillingAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingAddress" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Street">Street (required).</param>
        /// <param name="City">City name (required).</param>
        /// <param name="CountryName">Country name (required).</param>
        /// <param name="StateName">State name (required).</param>
        /// <param name="PostalCode">Postal Code (required).</param>
        public BillingAddress(string Name = null, string Street = null, string City = null, string CountryName = null, string StateName = null, string PostalCode = null)
        {
            // to ensure "Street" is required (not null)
            if (Street == null)
            {
                throw new InvalidDataException("Street is a required property for BillingAddress and cannot be null");
            }
            else
            {
                this.Street = Street;
            }
            // to ensure "City" is required (not null)
            if (City == null)
            {
                throw new InvalidDataException("City is a required property for BillingAddress and cannot be null");
            }
            else
            {
                this.City = City;
            }
            // to ensure "CountryName" is required (not null)
            if (CountryName == null)
            {
                throw new InvalidDataException("CountryName is a required property for BillingAddress and cannot be null");
            }
            else
            {
                this.CountryName = CountryName;
            }
            // to ensure "StateName" is required (not null)
            if (StateName == null)
            {
                throw new InvalidDataException("StateName is a required property for BillingAddress and cannot be null");
            }
            else
            {
                this.StateName = StateName;
            }
            // to ensure "PostalCode" is required (not null)
            if (PostalCode == null)
            {
                throw new InvalidDataException("PostalCode is a required property for BillingAddress and cannot be null");
            }
            else
            {
                this.PostalCode = PostalCode;
            }
            this.Name = Name;
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
        /// Street
        /// </summary>
        /// <value>Street</value>
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }
        /// <summary>
        /// City name
        /// </summary>
        /// <value>City name</value>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// Country name
        /// </summary>
        /// <value>Country name</value>
        [DataMember(Name="countryName", EmitDefaultValue=false)]
        public string CountryName { get; set; }
        /// <summary>
        /// State name
        /// </summary>
        /// <value>State name</value>
        [DataMember(Name="stateName", EmitDefaultValue=false)]
        public string StateName { get; set; }
        /// <summary>
        /// Postal Code
        /// </summary>
        /// <value>Postal Code</value>
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

            return true &&
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
                ) &&
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
