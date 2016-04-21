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
    public partial class Address :  IEquatable<Address>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" />class.
        /// </summary>
<<<<<<< HEAD
        /// <param name="Name">Name.</param>
        /// <param name="Street">Street.</param>
        /// <param name="City">City.</param>
        /// <param name="CountryName">CountryName.</param>
        /// <param name="StateName">StateName.</param>
        /// <param name="PostalCode">PostalCode.</param>

        public Address(string Name = null, string Street = null, string City = null, string CountryName = null, string StateName = null, string PostalCode = null)
        {
            this.Name = Name;
            this.Street = Street;
            this.City = City;
            this.CountryName = CountryName;
            this.StateName = StateName;
            this.PostalCode = PostalCode;
=======
        /// <param name="Country">Country.</param>
        /// <param name="A1">A1.</param>
        /// <param name="A3">A3.</param>
        /// <param name="RD">RD.</param>
        /// <param name="HNO">HNO.</param>
        /// <param name="LOC">LOC.</param>
        /// <param name="NAM">NAM.</param>
        /// <param name="PC">PC.</param>

        public Address(string Country = null, string A1 = null, string A3 = null, string RD = null, string HNO = null, string LOC = null, string NAM = null, string PC = null)
        {
            this.Country = Country;
            this.A1 = A1;
            this.A3 = A3;
            this.RD = RD;
            this.HNO = HNO;
            this.LOC = LOC;
            this.NAM = NAM;
            this.PC = PC;
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
        }

    
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
<<<<<<< HEAD
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; private set; }
=======
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets A1
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
=======
        [DataMember(Name="A1", EmitDefaultValue=false)]
        public string A1 { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets A3
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="street", EmitDefaultValue=false)]
        public string Street { get; set; }
=======
        [DataMember(Name="A3", EmitDefaultValue=false)]
        public string A3 { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets RD
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
=======
        [DataMember(Name="RD", EmitDefaultValue=false)]
        public string RD { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets HNO
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="countryName", EmitDefaultValue=false)]
        public string CountryName { get; set; }
=======
        [DataMember(Name="HNO", EmitDefaultValue=false)]
        public string HNO { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets LOC
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="stateName", EmitDefaultValue=false)]
        public string StateName { get; set; }
=======
        [DataMember(Name="LOC", EmitDefaultValue=false)]
        public string LOC { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets NAM
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="postalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
=======
        [DataMember(Name="NAM", EmitDefaultValue=false)]
        public string NAM { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets PC
        /// </summary>
<<<<<<< HEAD
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
=======
        [DataMember(Name="PC", EmitDefaultValue=false)]
        public string PC { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
<<<<<<< HEAD
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Street: ").Append(Street).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  StateName: ").Append(StateName).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
=======
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  A1: ").Append(A1).Append("\n");
            sb.Append("  A3: ").Append(A3).Append("\n");
            sb.Append("  RD: ").Append(RD).Append("\n");
            sb.Append("  HNO: ").Append(HNO).Append("\n");
            sb.Append("  LOC: ").Append(LOC).Append("\n");
            sb.Append("  NAM: ").Append(NAM).Append("\n");
            sb.Append("  PC: ").Append(PC).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            return this.Equals(obj as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="other">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
<<<<<<< HEAD
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
=======
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) &&
                (
                    this.A1 == other.A1 ||
                    this.A1 != null &&
                    this.A1.Equals(other.A1)
                ) &&
                (
                    this.A3 == other.A3 ||
                    this.A3 != null &&
                    this.A3.Equals(other.A3)
                ) &&
                (
                    this.RD == other.RD ||
                    this.RD != null &&
                    this.RD.Equals(other.RD)
                ) &&
                (
                    this.HNO == other.HNO ||
                    this.HNO != null &&
                    this.HNO.Equals(other.HNO)
                ) &&
                (
                    this.LOC == other.LOC ||
                    this.LOC != null &&
                    this.LOC.Equals(other.LOC)
                ) &&
                (
                    this.NAM == other.NAM ||
                    this.NAM != null &&
                    this.NAM.Equals(other.NAM)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                ) &&
                (
                    this.PC == other.PC ||
                    this.PC != null &&
                    this.PC.Equals(other.PC)
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
<<<<<<< HEAD
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
=======
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.A1 != null)
                    hash = hash * 59 + this.A1.GetHashCode();
                if (this.A3 != null)
                    hash = hash * 59 + this.A3.GetHashCode();
                if (this.RD != null)
                    hash = hash * 59 + this.RD.GetHashCode();
                if (this.HNO != null)
                    hash = hash * 59 + this.HNO.GetHashCode();
                if (this.LOC != null)
                    hash = hash * 59 + this.LOC.GetHashCode();
                if (this.NAM != null)
                    hash = hash * 59 + this.NAM.GetHashCode();
                if (this.PC != null)
                    hash = hash * 59 + this.PC.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                return hash;
            }
        }

    }
}
