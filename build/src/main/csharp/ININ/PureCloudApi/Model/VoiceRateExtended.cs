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
    public partial class VoiceRateExtended :  IEquatable<VoiceRateExtended>
    { 

        /// <summary>
        /// The voice rate type.
        /// </summary>
        /// <value>The voice rate type.</value>
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
        /// Initializes a new instance of the <see cref="VoiceRateExtended" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Currency">The ISO 4217 currency code of the voice rate. (required).</param>
        /// <param name="AmendmentId">The amendment Id of the voice rate. (required).</param>
        /// <param name="Type">The voice rate type. (required).</param>
        /// <param name="EffectiveDate">The effective date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ (required).</param>
        /// <param name="GroupName">The group containing this area code. (required).</param>
        /// <param name="AreaCode">The area code. (required).</param>
        /// <param name="DeletionMarker">The deletion marker. (required) (default to false).</param>
        /// <param name="OutboundRate">The outbound extended rate. (required).</param>
        /// <param name="OutboundDurationMinimumSeconds">The minimum duration charged in seconds. (required).</param>
        /// <param name="OutboundDurationIncrementSeconds">The billing duration increment in seconds. (required).</param>
        /// <param name="InboundTolledRate">The inbound tolled rate. (required).</param>
        /// <param name="InboundTolledDurationMinimumSeconds">The minimum duration charged in seconds. (required).</param>
        /// <param name="InboundTolledDurationIncrementSeconds">The billing duration increment in seconds. (required).</param>
        /// <param name="InboundTollFreeRate">The inbound toll-free rate. (required).</param>
        /// <param name="InboundTollFreeDurationMinimumSeconds">The minimum duration charged in seconds. (required).</param>
        /// <param name="InboundTollFreeDurationIncrementSeconds">The billing duration increment in seconds. (required).</param>

        public VoiceRateExtended(string Name = null, string Currency = null, string AmendmentId = null, TypeEnum? Type = null, DateTime? EffectiveDate = null, string GroupName = null, string AreaCode = null, bool? DeletionMarker = null, double? OutboundRate = null, int? OutboundDurationMinimumSeconds = null, int? OutboundDurationIncrementSeconds = null, double? InboundTolledRate = null, int? InboundTolledDurationMinimumSeconds = null, int? InboundTolledDurationIncrementSeconds = null, double? InboundTollFreeRate = null, int? InboundTollFreeDurationMinimumSeconds = null, int? InboundTollFreeDurationIncrementSeconds = null)
        {
            // to ensure "Currency" is required (not null)
            if (Currency == null)
            {
                throw new InvalidDataException("Currency is a required property for VoiceRateExtended and cannot be null");
            }
            else
            {
                this.Currency = Currency;
            }
            // to ensure "AmendmentId" is required (not null)
            if (AmendmentId == null)
            {
                throw new InvalidDataException("AmendmentId is a required property for VoiceRateExtended and cannot be null");
            }
            else
            {
                this.AmendmentId = AmendmentId;
            }
            // to ensure "Type" is required (not null)
            if (Type == null)
            {
                throw new InvalidDataException("Type is a required property for VoiceRateExtended and cannot be null");
            }
            else
            {
                this.Type = Type;
            }
            // to ensure "EffectiveDate" is required (not null)
            if (EffectiveDate == null)
            {
                throw new InvalidDataException("EffectiveDate is a required property for VoiceRateExtended and cannot be null");
            }
            else
            {
                this.EffectiveDate = EffectiveDate;
            }
            // to ensure "GroupName" is required (not null)
            if (GroupName == null)
            {
                throw new InvalidDataException("GroupName is a required property for VoiceRateExtended and cannot be null");
            }
            else
            {
                this.GroupName = GroupName;
            }
            // to ensure "AreaCode" is required (not null)
            if (AreaCode == null)
            {
                throw new InvalidDataException("AreaCode is a required property for VoiceRateExtended and cannot be null");
            }
            else
            {
                this.AreaCode = AreaCode;
            }
            // to ensure "DeletionMarker" is required (not null)
            if (DeletionMarker == null)
            {
                throw new InvalidDataException("DeletionMarker is a required property for VoiceRateExtended and cannot be null");
            }
            else
            {
                this.DeletionMarker = DeletionMarker;
            }
            // to ensure "OutboundRate" is required (not null)
            if (OutboundRate == null)
            {
                throw new InvalidDataException("OutboundRate is a required property for VoiceRateExtended and cannot be null");
            }
            else
            {
                this.OutboundRate = OutboundRate;
            }
            // to ensure "OutboundDurationMinimumSeconds" is required (not null)
            if (OutboundDurationMinimumSeconds == null)
            {
                throw new InvalidDataException("OutboundDurationMinimumSeconds is a required property for VoiceRateExtended and cannot be null");
            }
            else
            {
                this.OutboundDurationMinimumSeconds = OutboundDurationMinimumSeconds;
            }
            // to ensure "OutboundDurationIncrementSeconds" is required (not null)
            if (OutboundDurationIncrementSeconds == null)
            {
                throw new InvalidDataException("OutboundDurationIncrementSeconds is a required property for VoiceRateExtended and cannot be null");
            }
            else
            {
                this.OutboundDurationIncrementSeconds = OutboundDurationIncrementSeconds;
            }
            // to ensure "InboundTolledRate" is required (not null)
            if (InboundTolledRate == null)
            {
                throw new InvalidDataException("InboundTolledRate is a required property for VoiceRateExtended and cannot be null");
            }
            else
            {
                this.InboundTolledRate = InboundTolledRate;
            }
            // to ensure "InboundTolledDurationMinimumSeconds" is required (not null)
            if (InboundTolledDurationMinimumSeconds == null)
            {
                throw new InvalidDataException("InboundTolledDurationMinimumSeconds is a required property for VoiceRateExtended and cannot be null");
            }
            else
            {
                this.InboundTolledDurationMinimumSeconds = InboundTolledDurationMinimumSeconds;
            }
            // to ensure "InboundTolledDurationIncrementSeconds" is required (not null)
            if (InboundTolledDurationIncrementSeconds == null)
            {
                throw new InvalidDataException("InboundTolledDurationIncrementSeconds is a required property for VoiceRateExtended and cannot be null");
            }
            else
            {
                this.InboundTolledDurationIncrementSeconds = InboundTolledDurationIncrementSeconds;
            }
            // to ensure "InboundTollFreeRate" is required (not null)
            if (InboundTollFreeRate == null)
            {
                throw new InvalidDataException("InboundTollFreeRate is a required property for VoiceRateExtended and cannot be null");
            }
            else
            {
                this.InboundTollFreeRate = InboundTollFreeRate;
            }
            // to ensure "InboundTollFreeDurationMinimumSeconds" is required (not null)
            if (InboundTollFreeDurationMinimumSeconds == null)
            {
                throw new InvalidDataException("InboundTollFreeDurationMinimumSeconds is a required property for VoiceRateExtended and cannot be null");
            }
            else
            {
                this.InboundTollFreeDurationMinimumSeconds = InboundTollFreeDurationMinimumSeconds;
            }
            // to ensure "InboundTollFreeDurationIncrementSeconds" is required (not null)
            if (InboundTollFreeDurationIncrementSeconds == null)
            {
                throw new InvalidDataException("InboundTollFreeDurationIncrementSeconds is a required property for VoiceRateExtended and cannot be null");
            }
            else
            {
                this.InboundTollFreeDurationIncrementSeconds = InboundTollFreeDurationIncrementSeconds;
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
        /// The group containing this area code.
        /// </summary>
        /// <value>The group containing this area code.</value>
        [DataMember(Name="groupName", EmitDefaultValue=false)]
        public string GroupName { get; set; }
    
        /// <summary>
        /// The area code.
        /// </summary>
        /// <value>The area code.</value>
        [DataMember(Name="areaCode", EmitDefaultValue=false)]
        public string AreaCode { get; set; }
    
        /// <summary>
        /// The deletion marker.
        /// </summary>
        /// <value>The deletion marker.</value>
        [DataMember(Name="deletionMarker", EmitDefaultValue=false)]
        public bool? DeletionMarker { get; set; }
    
        /// <summary>
        /// The outbound extended rate.
        /// </summary>
        /// <value>The outbound extended rate.</value>
        [DataMember(Name="outboundRate", EmitDefaultValue=false)]
        public double? OutboundRate { get; set; }
    
        /// <summary>
        /// The minimum duration charged in seconds.
        /// </summary>
        /// <value>The minimum duration charged in seconds.</value>
        [DataMember(Name="outboundDurationMinimumSeconds", EmitDefaultValue=false)]
        public int? OutboundDurationMinimumSeconds { get; set; }
    
        /// <summary>
        /// The billing duration increment in seconds.
        /// </summary>
        /// <value>The billing duration increment in seconds.</value>
        [DataMember(Name="outboundDurationIncrementSeconds", EmitDefaultValue=false)]
        public int? OutboundDurationIncrementSeconds { get; set; }
    
        /// <summary>
        /// The inbound tolled rate.
        /// </summary>
        /// <value>The inbound tolled rate.</value>
        [DataMember(Name="inboundTolledRate", EmitDefaultValue=false)]
        public double? InboundTolledRate { get; set; }
    
        /// <summary>
        /// The minimum duration charged in seconds.
        /// </summary>
        /// <value>The minimum duration charged in seconds.</value>
        [DataMember(Name="inboundTolledDurationMinimumSeconds", EmitDefaultValue=false)]
        public int? InboundTolledDurationMinimumSeconds { get; set; }
    
        /// <summary>
        /// The billing duration increment in seconds.
        /// </summary>
        /// <value>The billing duration increment in seconds.</value>
        [DataMember(Name="inboundTolledDurationIncrementSeconds", EmitDefaultValue=false)]
        public int? InboundTolledDurationIncrementSeconds { get; set; }
    
        /// <summary>
        /// The inbound toll-free rate.
        /// </summary>
        /// <value>The inbound toll-free rate.</value>
        [DataMember(Name="inboundTollFreeRate", EmitDefaultValue=false)]
        public double? InboundTollFreeRate { get; set; }
    
        /// <summary>
        /// The minimum duration charged in seconds.
        /// </summary>
        /// <value>The minimum duration charged in seconds.</value>
        [DataMember(Name="inboundTollFreeDurationMinimumSeconds", EmitDefaultValue=false)]
        public int? InboundTollFreeDurationMinimumSeconds { get; set; }
    
        /// <summary>
        /// The billing duration increment in seconds.
        /// </summary>
        /// <value>The billing duration increment in seconds.</value>
        [DataMember(Name="inboundTollFreeDurationIncrementSeconds", EmitDefaultValue=false)]
        public int? InboundTollFreeDurationIncrementSeconds { get; set; }
    
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
            sb.Append("class VoiceRateExtended {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  AmendmentId: ").Append(AmendmentId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  AreaCode: ").Append(AreaCode).Append("\n");
            sb.Append("  DeletionMarker: ").Append(DeletionMarker).Append("\n");
            sb.Append("  OutboundRate: ").Append(OutboundRate).Append("\n");
            sb.Append("  OutboundDurationMinimumSeconds: ").Append(OutboundDurationMinimumSeconds).Append("\n");
            sb.Append("  OutboundDurationIncrementSeconds: ").Append(OutboundDurationIncrementSeconds).Append("\n");
            sb.Append("  InboundTolledRate: ").Append(InboundTolledRate).Append("\n");
            sb.Append("  InboundTolledDurationMinimumSeconds: ").Append(InboundTolledDurationMinimumSeconds).Append("\n");
            sb.Append("  InboundTolledDurationIncrementSeconds: ").Append(InboundTolledDurationIncrementSeconds).Append("\n");
            sb.Append("  InboundTollFreeRate: ").Append(InboundTollFreeRate).Append("\n");
            sb.Append("  InboundTollFreeDurationMinimumSeconds: ").Append(InboundTollFreeDurationMinimumSeconds).Append("\n");
            sb.Append("  InboundTollFreeDurationIncrementSeconds: ").Append(InboundTollFreeDurationIncrementSeconds).Append("\n");
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
            return this.Equals(obj as VoiceRateExtended);
        }

        /// <summary>
        /// Returns true if VoiceRateExtended instances are equal
        /// </summary>
        /// <param name="other">Instance of VoiceRateExtended to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoiceRateExtended other)
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
                    this.GroupName == other.GroupName ||
                    this.GroupName != null &&
                    this.GroupName.Equals(other.GroupName)
                ) &&
                (
                    this.AreaCode == other.AreaCode ||
                    this.AreaCode != null &&
                    this.AreaCode.Equals(other.AreaCode)
                ) &&
                (
                    this.DeletionMarker == other.DeletionMarker ||
                    this.DeletionMarker != null &&
                    this.DeletionMarker.Equals(other.DeletionMarker)
                ) &&
                (
                    this.OutboundRate == other.OutboundRate ||
                    this.OutboundRate != null &&
                    this.OutboundRate.Equals(other.OutboundRate)
                ) &&
                (
                    this.OutboundDurationMinimumSeconds == other.OutboundDurationMinimumSeconds ||
                    this.OutboundDurationMinimumSeconds != null &&
                    this.OutboundDurationMinimumSeconds.Equals(other.OutboundDurationMinimumSeconds)
                ) &&
                (
                    this.OutboundDurationIncrementSeconds == other.OutboundDurationIncrementSeconds ||
                    this.OutboundDurationIncrementSeconds != null &&
                    this.OutboundDurationIncrementSeconds.Equals(other.OutboundDurationIncrementSeconds)
                ) &&
                (
                    this.InboundTolledRate == other.InboundTolledRate ||
                    this.InboundTolledRate != null &&
                    this.InboundTolledRate.Equals(other.InboundTolledRate)
                ) &&
                (
                    this.InboundTolledDurationMinimumSeconds == other.InboundTolledDurationMinimumSeconds ||
                    this.InboundTolledDurationMinimumSeconds != null &&
                    this.InboundTolledDurationMinimumSeconds.Equals(other.InboundTolledDurationMinimumSeconds)
                ) &&
                (
                    this.InboundTolledDurationIncrementSeconds == other.InboundTolledDurationIncrementSeconds ||
                    this.InboundTolledDurationIncrementSeconds != null &&
                    this.InboundTolledDurationIncrementSeconds.Equals(other.InboundTolledDurationIncrementSeconds)
                ) &&
                (
                    this.InboundTollFreeRate == other.InboundTollFreeRate ||
                    this.InboundTollFreeRate != null &&
                    this.InboundTollFreeRate.Equals(other.InboundTollFreeRate)
                ) &&
                (
                    this.InboundTollFreeDurationMinimumSeconds == other.InboundTollFreeDurationMinimumSeconds ||
                    this.InboundTollFreeDurationMinimumSeconds != null &&
                    this.InboundTollFreeDurationMinimumSeconds.Equals(other.InboundTollFreeDurationMinimumSeconds)
                ) &&
                (
                    this.InboundTollFreeDurationIncrementSeconds == other.InboundTollFreeDurationIncrementSeconds ||
                    this.InboundTollFreeDurationIncrementSeconds != null &&
                    this.InboundTollFreeDurationIncrementSeconds.Equals(other.InboundTollFreeDurationIncrementSeconds)
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
                if (this.GroupName != null)
                    hash = hash * 59 + this.GroupName.GetHashCode();
                if (this.AreaCode != null)
                    hash = hash * 59 + this.AreaCode.GetHashCode();
                if (this.DeletionMarker != null)
                    hash = hash * 59 + this.DeletionMarker.GetHashCode();
                if (this.OutboundRate != null)
                    hash = hash * 59 + this.OutboundRate.GetHashCode();
                if (this.OutboundDurationMinimumSeconds != null)
                    hash = hash * 59 + this.OutboundDurationMinimumSeconds.GetHashCode();
                if (this.OutboundDurationIncrementSeconds != null)
                    hash = hash * 59 + this.OutboundDurationIncrementSeconds.GetHashCode();
                if (this.InboundTolledRate != null)
                    hash = hash * 59 + this.InboundTolledRate.GetHashCode();
                if (this.InboundTolledDurationMinimumSeconds != null)
                    hash = hash * 59 + this.InboundTolledDurationMinimumSeconds.GetHashCode();
                if (this.InboundTolledDurationIncrementSeconds != null)
                    hash = hash * 59 + this.InboundTolledDurationIncrementSeconds.GetHashCode();
                if (this.InboundTollFreeRate != null)
                    hash = hash * 59 + this.InboundTollFreeRate.GetHashCode();
                if (this.InboundTollFreeDurationMinimumSeconds != null)
                    hash = hash * 59 + this.InboundTollFreeDurationMinimumSeconds.GetHashCode();
                if (this.InboundTollFreeDurationIncrementSeconds != null)
                    hash = hash * 59 + this.InboundTollFreeDurationIncrementSeconds.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
