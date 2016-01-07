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
    public class VoiceRateExtended :  IEquatable<VoiceRateExtended>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceRateExtended" /> class.
        /// </summary>
        public VoiceRateExtended()
        {
            this.DeletionMarker = false;
            
        }

        
        /// <summary>
        /// The globally unique identifier for the object.
        /// </summary>
        /// <value>The globally unique identifier for the object.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
  
        
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
        /// The voice rate type.
        /// </summary>
        /// <value>The voice rate type.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
  
        
        /// <summary>
        /// The effective date.
        /// </summary>
        /// <value>The effective date.</value>
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
        public string SelfUri { get; set; }
  
        
  
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
        /// <param name="obj">Instance of VoiceRateExtended to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoiceRateExtended other)
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
                    hash = hash * 57 + this.Id.GetHashCode();
                
                if (this.Name != null)
                    hash = hash * 57 + this.Name.GetHashCode();
                
                if (this.Currency != null)
                    hash = hash * 57 + this.Currency.GetHashCode();
                
                if (this.AmendmentId != null)
                    hash = hash * 57 + this.AmendmentId.GetHashCode();
                
                if (this.Type != null)
                    hash = hash * 57 + this.Type.GetHashCode();
                
                if (this.EffectiveDate != null)
                    hash = hash * 57 + this.EffectiveDate.GetHashCode();
                
                if (this.GroupName != null)
                    hash = hash * 57 + this.GroupName.GetHashCode();
                
                if (this.AreaCode != null)
                    hash = hash * 57 + this.AreaCode.GetHashCode();
                
                if (this.DeletionMarker != null)
                    hash = hash * 57 + this.DeletionMarker.GetHashCode();
                
                if (this.OutboundRate != null)
                    hash = hash * 57 + this.OutboundRate.GetHashCode();
                
                if (this.OutboundDurationMinimumSeconds != null)
                    hash = hash * 57 + this.OutboundDurationMinimumSeconds.GetHashCode();
                
                if (this.OutboundDurationIncrementSeconds != null)
                    hash = hash * 57 + this.OutboundDurationIncrementSeconds.GetHashCode();
                
                if (this.InboundTolledRate != null)
                    hash = hash * 57 + this.InboundTolledRate.GetHashCode();
                
                if (this.InboundTolledDurationMinimumSeconds != null)
                    hash = hash * 57 + this.InboundTolledDurationMinimumSeconds.GetHashCode();
                
                if (this.InboundTolledDurationIncrementSeconds != null)
                    hash = hash * 57 + this.InboundTolledDurationIncrementSeconds.GetHashCode();
                
                if (this.InboundTollFreeRate != null)
                    hash = hash * 57 + this.InboundTollFreeRate.GetHashCode();
                
                if (this.InboundTollFreeDurationMinimumSeconds != null)
                    hash = hash * 57 + this.InboundTollFreeDurationMinimumSeconds.GetHashCode();
                
                if (this.InboundTollFreeDurationIncrementSeconds != null)
                    hash = hash * 57 + this.InboundTollFreeDurationIncrementSeconds.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
