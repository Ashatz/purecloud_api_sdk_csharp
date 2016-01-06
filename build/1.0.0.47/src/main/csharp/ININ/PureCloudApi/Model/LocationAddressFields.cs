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
    public class LocationAddressFields :  IEquatable<LocationAddressFields>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocationAddressFields" /> class.
        /// </summary>
        public LocationAddressFields()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
  
        
        /// <summary>
        /// Gets or Sets CountryName
        /// </summary>
        [DataMember(Name="countryName", EmitDefaultValue=false)]
        public string CountryName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Street1
        /// </summary>
        [DataMember(Name="street1", EmitDefaultValue=false)]
        public string Street1 { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Street2
        /// </summary>
        [DataMember(Name="street2", EmitDefaultValue=false)]
        public string Street2 { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Zipcode
        /// </summary>
        [DataMember(Name="zipcode", EmitDefaultValue=false)]
        public string Zipcode { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocationAddressFields {\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  CountryName: ").Append(CountryName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Street1: ").Append(Street1).Append("\n");
            sb.Append("  Street2: ").Append(Street2).Append("\n");
            sb.Append("  Zipcode: ").Append(Zipcode).Append("\n");
            
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
            return this.Equals(obj as LocationAddressFields);
        }

        /// <summary>
        /// Returns true if LocationAddressFields instances are equal
        /// </summary>
        /// <param name="obj">Instance of LocationAddressFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocationAddressFields other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) && 
                (
                    this.CountryName == other.CountryName ||
                    this.CountryName != null &&
                    this.CountryName.Equals(other.CountryName)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.Street1 == other.Street1 ||
                    this.Street1 != null &&
                    this.Street1.Equals(other.Street1)
                ) && 
                (
                    this.Street2 == other.Street2 ||
                    this.Street2 != null &&
                    this.Street2.Equals(other.Street2)
                ) && 
                (
                    this.Zipcode == other.Zipcode ||
                    this.Zipcode != null &&
                    this.Zipcode.Equals(other.Zipcode)
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
                
                if (this.City != null)
                    hash = hash * 57 + this.City.GetHashCode();
                
                if (this.Country != null)
                    hash = hash * 57 + this.Country.GetHashCode();
                
                if (this.CountryName != null)
                    hash = hash * 57 + this.CountryName.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 57 + this.State.GetHashCode();
                
                if (this.Street1 != null)
                    hash = hash * 57 + this.Street1.GetHashCode();
                
                if (this.Street2 != null)
                    hash = hash * 57 + this.Street2.GetHashCode();
                
                if (this.Zipcode != null)
                    hash = hash * 57 + this.Zipcode.GetHashCode();
                
                return hash;
            }
        }

    }


}
