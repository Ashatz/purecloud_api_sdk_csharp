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
    public partial class PenetrationRate :  IEquatable<PenetrationRate>
    { 
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PenetrationRate" /> class.
        /// Initializes a new instance of the <see cref="PenetrationRate" />class.
        /// </summary>
        /// <param name="NumberOfContactsCalled">NumberOfContactsCalled.</param>
        /// <param name="TotalNumberOfContacts">TotalNumberOfContacts.</param>
        /// <param name="Percentage">Percentage.</param>
        /// <param name="PenetrationRateId">PenetrationRateId.</param>

        public PenetrationRate(long? NumberOfContactsCalled = null, long? TotalNumberOfContacts = null, long? Percentage = null, PenetrationRateId PenetrationRateId = null)
        {
            this.NumberOfContactsCalled = NumberOfContactsCalled;
            this.TotalNumberOfContacts = TotalNumberOfContacts;
            this.Percentage = Percentage;
            this.PenetrationRateId = PenetrationRateId;
            
        }
        
    
        /// <summary>
        /// Gets or Sets NumberOfContactsCalled
        /// </summary>
        [DataMember(Name="numberOfContactsCalled", EmitDefaultValue=false)]
        public long? NumberOfContactsCalled { get; set; }
    
        /// <summary>
        /// Gets or Sets TotalNumberOfContacts
        /// </summary>
        [DataMember(Name="totalNumberOfContacts", EmitDefaultValue=false)]
        public long? TotalNumberOfContacts { get; set; }
    
        /// <summary>
        /// Gets or Sets Percentage
        /// </summary>
        [DataMember(Name="percentage", EmitDefaultValue=false)]
        public long? Percentage { get; set; }
    
        /// <summary>
        /// Gets or Sets PenetrationRateId
        /// </summary>
        [DataMember(Name="penetrationRateId", EmitDefaultValue=false)]
        public PenetrationRateId PenetrationRateId { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PenetrationRate {\n");
            sb.Append("  NumberOfContactsCalled: ").Append(NumberOfContactsCalled).Append("\n");
            sb.Append("  TotalNumberOfContacts: ").Append(TotalNumberOfContacts).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  PenetrationRateId: ").Append(PenetrationRateId).Append("\n");
            
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
            return this.Equals(obj as PenetrationRate);
        }

        /// <summary>
        /// Returns true if PenetrationRate instances are equal
        /// </summary>
        /// <param name="other">Instance of PenetrationRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PenetrationRate other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.NumberOfContactsCalled == other.NumberOfContactsCalled ||
                    this.NumberOfContactsCalled != null &&
                    this.NumberOfContactsCalled.Equals(other.NumberOfContactsCalled)
                ) && 
                (
                    this.TotalNumberOfContacts == other.TotalNumberOfContacts ||
                    this.TotalNumberOfContacts != null &&
                    this.TotalNumberOfContacts.Equals(other.TotalNumberOfContacts)
                ) && 
                (
                    this.Percentage == other.Percentage ||
                    this.Percentage != null &&
                    this.Percentage.Equals(other.Percentage)
                ) && 
                (
                    this.PenetrationRateId == other.PenetrationRateId ||
                    this.PenetrationRateId != null &&
                    this.PenetrationRateId.Equals(other.PenetrationRateId)
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
                
                if (this.NumberOfContactsCalled != null)
                    hash = hash * 59 + this.NumberOfContactsCalled.GetHashCode();
                
                if (this.TotalNumberOfContacts != null)
                    hash = hash * 59 + this.TotalNumberOfContacts.GetHashCode();
                
                if (this.Percentage != null)
                    hash = hash * 59 + this.Percentage.GetHashCode();
                
                if (this.PenetrationRateId != null)
                    hash = hash * 59 + this.PenetrationRateId.GetHashCode();
                
                return hash;
            }
        }

    }
}
