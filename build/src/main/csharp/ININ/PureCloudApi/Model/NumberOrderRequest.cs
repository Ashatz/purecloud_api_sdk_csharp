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
    public partial class NumberOrderRequest :  IEquatable<NumberOrderRequest>
    { 

        /// <summary>
        /// The type of phone number (eg us-domestic, toll-free, etc), to determine which third-party api(s) to use for the order request.
        /// </summary>
        /// <value>The type of phone number (eg us-domestic, toll-free, etc), to determine which third-party api(s) to use for the order request.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PhoneNumberTypeEnum {
            
            [EnumMember(Value = "TOLL_FREE")]
            TollFree,
            
            [EnumMember(Value = "CN_DOMESTIC")]
            CnDomestic,
            
            [EnumMember(Value = "US_DOMESTIC")]
            UsDomestic
        }

        

        /// <summary>
        /// The type of phone number (eg us-domestic, toll-free, etc), to determine which third-party api(s) to use for the order request.
        /// </summary>
        /// <value>The type of phone number (eg us-domestic, toll-free, etc), to determine which third-party api(s) to use for the order request.</value>
        [DataMember(Name="phoneNumberType", EmitDefaultValue=false)]
        public PhoneNumberTypeEnum? PhoneNumberType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NumberOrderRequest" />class.
        /// </summary>
        /// <param name="OrderTns">OrderTns.</param>
        /// <param name="ReservationIds">ReservationIds.</param>
        /// <param name="OrderId">OrderId.</param>
        /// <param name="EffectiveDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="PhoneNumberType">The type of phone number (eg us-domestic, toll-free, etc), to determine which third-party api(s) to use for the order request..</param>

        public NumberOrderRequest(List<string> OrderTns = null, List<string> ReservationIds = null, string OrderId = null, DateTime? EffectiveDate = null, PhoneNumberTypeEnum? PhoneNumberType = null)
        {
            this.OrderTns = OrderTns;
            this.ReservationIds = ReservationIds;
            this.OrderId = OrderId;
            this.EffectiveDate = EffectiveDate;
            this.PhoneNumberType = PhoneNumberType;
            
        }

    
        /// <summary>
        /// Gets or Sets OrderTns
        /// </summary>
        [DataMember(Name="orderTns", EmitDefaultValue=false)]
        public List<string> OrderTns { get; set; }
    
        /// <summary>
        /// Gets or Sets ReservationIds
        /// </summary>
        [DataMember(Name="reservationIds", EmitDefaultValue=false)]
        public List<string> ReservationIds { get; set; }
    
        /// <summary>
        /// Gets or Sets OrderId
        /// </summary>
        [DataMember(Name="orderId", EmitDefaultValue=false)]
        public string OrderId { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
        public DateTime? EffectiveDate { get; set; }
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NumberOrderRequest {\n");
            sb.Append("  OrderTns: ").Append(OrderTns).Append("\n");
            sb.Append("  ReservationIds: ").Append(ReservationIds).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
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
            return this.Equals(obj as NumberOrderRequest);
        }

        /// <summary>
        /// Returns true if NumberOrderRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of NumberOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NumberOrderRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.OrderTns == other.OrderTns ||
                    this.OrderTns != null &&
                    this.OrderTns.SequenceEqual(other.OrderTns)
                ) &&
                (
                    this.ReservationIds == other.ReservationIds ||
                    this.ReservationIds != null &&
                    this.ReservationIds.SequenceEqual(other.ReservationIds)
                ) &&
                (
                    this.OrderId == other.OrderId ||
                    this.OrderId != null &&
                    this.OrderId.Equals(other.OrderId)
                ) &&
                (
                    this.EffectiveDate == other.EffectiveDate ||
                    this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(other.EffectiveDate)
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
                if (this.OrderTns != null)
                    hash = hash * 59 + this.OrderTns.GetHashCode();
                if (this.ReservationIds != null)
                    hash = hash * 59 + this.ReservationIds.GetHashCode();
                if (this.OrderId != null)
                    hash = hash * 59 + this.OrderId.GetHashCode();
                if (this.EffectiveDate != null)
                    hash = hash * 59 + this.EffectiveDate.GetHashCode();
                if (this.PhoneNumberType != null)
                    hash = hash * 59 + this.PhoneNumberType.GetHashCode();
                return hash;
            }
        }

    }
}
