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
    public partial class CarrierAddress :  IEquatable<CarrierAddress>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CarrierAddress" /> class.
        /// Initializes a new instance of the <see cref="CarrierAddress" />class.
        /// </summary>
        /// <param name="StreetAddress1">StreetAddress1.</param>
        /// <param name="StreetAddress2">StreetAddress2.</param>
        /// <param name="City">City.</param>
        /// <param name="State">State.</param>
        /// <param name="Zipcode">Zipcode.</param>

        public CarrierAddress(string StreetAddress1 = null, string StreetAddress2 = null, string City = null, string State = null, string Zipcode = null)
        {
            this.StreetAddress1 = StreetAddress1;
            this.StreetAddress2 = StreetAddress2;
            this.City = City;
            this.State = State;
            this.Zipcode = Zipcode;
            
        }
        
    
        /// <summary>
        /// Gets or Sets StreetAddress1
        /// </summary>
        [DataMember(Name="streetAddress1", EmitDefaultValue=false)]
        public string StreetAddress1 { get; set; }
    
        /// <summary>
        /// Gets or Sets StreetAddress2
        /// </summary>
        [DataMember(Name="streetAddress2", EmitDefaultValue=false)]
        public string StreetAddress2 { get; set; }
    
        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name="city", EmitDefaultValue=false)]
        public string City { get; set; }
    
        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }
    
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
            sb.Append("class CarrierAddress {\n");
            sb.Append("  StreetAddress1: ").Append(StreetAddress1).Append("\n");
            sb.Append("  StreetAddress2: ").Append(StreetAddress2).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(obj as CarrierAddress);
        }

        /// <summary>
        /// Returns true if CarrierAddress instances are equal
        /// </summary>
        /// <param name="other">Instance of CarrierAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CarrierAddress other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.StreetAddress1 == other.StreetAddress1 ||
                    this.StreetAddress1 != null &&
                    this.StreetAddress1.Equals(other.StreetAddress1)
                ) && 
                (
                    this.StreetAddress2 == other.StreetAddress2 ||
                    this.StreetAddress2 != null &&
                    this.StreetAddress2.Equals(other.StreetAddress2)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
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
                
                if (this.StreetAddress1 != null)
                    hash = hash * 59 + this.StreetAddress1.GetHashCode();
                
                if (this.StreetAddress2 != null)
                    hash = hash * 59 + this.StreetAddress2.GetHashCode();
                
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                
                if (this.Zipcode != null)
                    hash = hash * 59 + this.Zipcode.GetHashCode();
                
                return hash;
            }
        }

    }
}
