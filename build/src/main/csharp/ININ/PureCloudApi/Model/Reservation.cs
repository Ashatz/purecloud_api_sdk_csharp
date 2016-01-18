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
    public class Reservation :  IEquatable<Reservation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reservation" /> class.
        /// </summary>
        public Reservation()
        {
            
        }

        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ReservedTn
        /// </summary>
        [DataMember(Name="reservedTn", EmitDefaultValue=false)]
        public string ReservedTn { get; set; }
  
        
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="reservationExpires", EmitDefaultValue=false)]
        public DateTime? ReservationExpires { get; set; }
  
        
        /// <summary>
        /// The type of phone number (eg us-domestic, toll-free, etc).
        /// </summary>
        /// <value>The type of phone number (eg us-domestic, toll-free, etc).</value>
        [DataMember(Name="phoneNumberType", EmitDefaultValue=false)]
        public string PhoneNumberType { get; set; }
  
        
  
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Reservation {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ReservedTn: ").Append(ReservedTn).Append("\n");
            sb.Append("  ReservationExpires: ").Append(ReservationExpires).Append("\n");
            sb.Append("  PhoneNumberType: ").Append(PhoneNumberType).Append("\n");
            
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
            return this.Equals(obj as Reservation);
        }

        /// <summary>
        /// Returns true if Reservation instances are equal
        /// </summary>
        /// <param name="obj">Instance of Reservation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Reservation other)
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
                    this.ReservedTn == other.ReservedTn ||
                    this.ReservedTn != null &&
                    this.ReservedTn.Equals(other.ReservedTn)
                ) && 
                (
                    this.ReservationExpires == other.ReservationExpires ||
                    this.ReservationExpires != null &&
                    this.ReservationExpires.Equals(other.ReservationExpires)
                ) && 
                (
                    this.PhoneNumberType == other.PhoneNumberType ||
                    this.PhoneNumberType != null &&
                    this.PhoneNumberType.Equals(other.PhoneNumberType)
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
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.ReservedTn != null)
                    hash = hash * 57 + this.ReservedTn.GetHashCode();
                
                if (this.ReservationExpires != null)
                    hash = hash * 57 + this.ReservationExpires.GetHashCode();
                
                if (this.PhoneNumberType != null)
                    hash = hash * 57 + this.PhoneNumberType.GetHashCode();
                
                return hash;
            }
        }

    }


}