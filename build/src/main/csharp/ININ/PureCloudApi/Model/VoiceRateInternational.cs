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
    public partial class VoiceRateInternational :  IEquatable<VoiceRateInternational>
    { 
    
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum {
            
            [EnumMember(Value = "RATE_TOLL_FREE")]
            RateTollFree,
            
            [EnumMember(Value = "RATE_TOLLED")]
            RateTolled,
            
            [EnumMember(Value = "OUTBOUND_INTERSTATE")]
            OutboundInterstate,
            
            [EnumMember(Value = "OUTBOUND_INTRASTATE")]
            OutboundIntrastate,
            
            [EnumMember(Value = "OUTBOUND_LOCAL")]
            OutboundLocal,
            
            [EnumMember(Value = "EXTENDED")]
            Extended
        }
        
        /// <summary>
        /// The voice rate type.
        /// </summary>
        /// <value>The voice rate type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceRateInternational" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Currency">The ISO 4217 currency code of the voice rate. (required).</param>
        /// <param name="AmendmentId">The amendment Id of the voice rate. (required).</param>
        /// <param name="Type">The voice rate type. (required).</param>
        /// <param name="EffectiveDate">The effective date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (required).</param>
        /// <param name="Rate">The rate. (required).</param>
        /// <param name="DurationMinimumSeconds">The minimum duration charged in seconds. (required).</param>
        /// <param name="DurationIncrementSeconds">The billing duration increment in seconds. (required).</param>
        /// <param name="Origin">The origin. (required).</param>
        /// <param name="Destination">The destination. (required).</param>

        public VoiceRateInternational(string Name = null, string Currency = null, string AmendmentId = null, TypeEnum? Type = null, DateTime? EffectiveDate = null, double? Rate = null, int? DurationMinimumSeconds = null, int? DurationIncrementSeconds = null, string Origin = null, string Destination = null, )
        {
            // to ensure "Currency" is required (not null)
            if (Currency == null)
            {
                throw new InvalidDataException("Currency is a required property for VoiceRateInternational and cannot be null");
            }
            else
            {
                this.Currency = Currency;
            }
            // to ensure "AmendmentId" is required (not null)
            if (AmendmentId == null)
            {
                throw new InvalidDataException("AmendmentId is a required property for VoiceRateInternational and cannot be null");
            }
            else
            {
                this.AmendmentId = AmendmentId;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for VoiceRateInternational and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "EffectiveDate" is required (not null)
            if (EffectiveDate == null)
            {
                throw new InvalidDataException("EffectiveDate is a required property for VoiceRateInternational and cannot be null");
            }
            else
            {
                this.EffectiveDate = EffectiveDate;
            }
            // to ensure "Rate" is required (not null)
            if (Rate == null)
            {
                throw new InvalidDataException("Rate is a required property for VoiceRateInternational and cannot be null");
            }
            else
            {
                this.Rate = Rate;
            }
            // to ensure "DurationMinimumSeconds" is required (not null)
            if (DurationMinimumSeconds == null)
            {
                throw new InvalidDataException("DurationMinimumSeconds is a required property for VoiceRateInternational and cannot be null");
            }
            else
            {
                this.DurationMinimumSeconds = DurationMinimumSeconds;
            }
            // to ensure "DurationIncrementSeconds" is required (not null)
            if (DurationIncrementSeconds == null)
            {
                throw new InvalidDataException("DurationIncrementSeconds is a required property for VoiceRateInternational and cannot be null");
            }
            else
            {
                this.DurationIncrementSeconds = DurationIncrementSeconds;
            }
            // to ensure "Origin" is required (not null)
            if (Origin == null)
            {
                throw new InvalidDataException("Origin is a required property for VoiceRateInternational and cannot be null");
            }
            else
            {
                this.Origin = Origin;
            }
            // to ensure "Destination" is required (not null)
            if (Destination == null)
            {
                throw new InvalidDataException("Destination is a required property for VoiceRateInternational and cannot be null");
            }
            else
            {
                this.Destination = Destination;
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
        /// The ISO 4217 currency code of the voice rate.
        /// </summary>
        /// <value>The ISO 4217 currency code of the voice rate.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
    
        /// <summary>
        /// The amendment Id of the voice rate.
        /// </summary>
        /// <value>The amendment Id of the voice rate.</value>
        [DataMember(Name="amendmentId", EmitDefaultValue=false)]
        public string AmendmentId { get; set; }
    
        /// <summary>
        /// The effective date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>The effective date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
        public DateTime? EffectiveDate { get; set; }
    
        /// <summary>
        /// The rate.
        /// </summary>
        /// <value>The rate.</value>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public double? Rate { get; set; }
    
        /// <summary>
        /// The minimum duration charged in seconds.
        /// </summary>
        /// <value>The minimum duration charged in seconds.</value>
        [DataMember(Name="durationMinimumSeconds", EmitDefaultValue=false)]
        public int? DurationMinimumSeconds { get; set; }
    
        /// <summary>
        /// The billing duration increment in seconds.
        /// </summary>
        /// <value>The billing duration increment in seconds.</value>
        [DataMember(Name="durationIncrementSeconds", EmitDefaultValue=false)]
        public int? DurationIncrementSeconds { get; set; }
    
        /// <summary>
        /// The origin.
        /// </summary>
        /// <value>The origin.</value>
        [DataMember(Name="origin", EmitDefaultValue=false)]
        public string Origin { get; set; }
    
        /// <summary>
        /// The destination.
        /// </summary>
        /// <value>The destination.</value>
        [DataMember(Name="destination", EmitDefaultValue=false)]
        public string Destination { get; set; }
    
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
            sb.Append("class VoiceRateInternational {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  AmendmentId: ").Append(AmendmentId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  DurationMinimumSeconds: ").Append(DurationMinimumSeconds).Append("\n");
            sb.Append("  DurationIncrementSeconds: ").Append(DurationIncrementSeconds).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
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
            return this.Equals(obj as VoiceRateInternational);
        }

        /// <summary>
        /// Returns true if VoiceRateInternational instances are equal
        /// </summary>
        /// <param name="other">Instance of VoiceRateInternational to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoiceRateInternational other)
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
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) &&
                (
                    this.AmendmentId == other.AmendmentId ||
                    this.AmendmentId != null &&
                    this.AmendmentId.Equals(other.AmendmentId)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.EffectiveDate == other.EffectiveDate ||
                    this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(other.EffectiveDate)
                ) &&
                (
                    this.Rate == other.Rate ||
                    this.Rate != null &&
                    this.Rate.Equals(other.Rate)
                ) &&
                (
                    this.DurationMinimumSeconds == other.DurationMinimumSeconds ||
                    this.DurationMinimumSeconds != null &&
                    this.DurationMinimumSeconds.Equals(other.DurationMinimumSeconds)
                ) &&
                (
                    this.DurationIncrementSeconds == other.DurationIncrementSeconds ||
                    this.DurationIncrementSeconds != null &&
                    this.DurationIncrementSeconds.Equals(other.DurationIncrementSeconds)
                ) &&
                (
                    this.Origin == other.Origin ||
                    this.Origin != null &&
                    this.Origin.Equals(other.Origin)
                ) &&
                (
                    this.Destination == other.Destination ||
                    this.Destination != null &&
                    this.Destination.Equals(other.Destination)
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
                
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                
                if (this.AmendmentId != null)
                    hash = hash * 59 + this.AmendmentId.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                
                if (this.EffectiveDate != null)
                    hash = hash * 59 + this.EffectiveDate.GetHashCode();
                
                if (this.Rate != null)
                    hash = hash * 59 + this.Rate.GetHashCode();
                
                if (this.DurationMinimumSeconds != null)
                    hash = hash * 59 + this.DurationMinimumSeconds.GetHashCode();
                
                if (this.DurationIncrementSeconds != null)
                    hash = hash * 59 + this.DurationIncrementSeconds.GetHashCode();
                
                if (this.Origin != null)
                    hash = hash * 59 + this.Origin.GetHashCode();
                
                if (this.Destination != null)
                    hash = hash * 59 + this.Destination.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
