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
    public class VoiceRateUpdate :  IEquatable<VoiceRateUpdate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceRateUpdate" /> class.
        /// </summary>
        public VoiceRateUpdate()
        {
            
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
        /// The inbound toll free rate.
        /// </summary>
        /// <value>The inbound toll free rate.</value>
        [DataMember(Name="inboundTollFree", EmitDefaultValue=false)]
        public VoiceRate InboundTollFree { get; set; }
  
        
        /// <summary>
        /// The domestic extended rates.
        /// </summary>
        /// <value>The domestic extended rates.</value>
        [DataMember(Name="extended", EmitDefaultValue=false)]
        public List<VoiceRateExtended> Extended { get; set; }
  
        
        /// <summary>
        /// The inbound tolled rate.
        /// </summary>
        /// <value>The inbound tolled rate.</value>
        [DataMember(Name="inboundTolled", EmitDefaultValue=false)]
        public VoiceRate InboundTolled { get; set; }
  
        
        /// <summary>
        /// The outbound local rate.
        /// </summary>
        /// <value>The outbound local rate.</value>
        [DataMember(Name="outboundLocal", EmitDefaultValue=false)]
        public VoiceRate OutboundLocal { get; set; }
  
        
        /// <summary>
        /// The outbound intra-state rate.
        /// </summary>
        /// <value>The outbound intra-state rate.</value>
        [DataMember(Name="outboundIntraState", EmitDefaultValue=false)]
        public VoiceRate OutboundIntraState { get; set; }
  
        
        /// <summary>
        /// The outbound inter-state rate.
        /// </summary>
        /// <value>The outbound inter-state rate.</value>
        [DataMember(Name="outboundInterState", EmitDefaultValue=false)]
        public VoiceRate OutboundInterState { get; set; }
  
        
        /// <summary>
        /// The outbound international rates.
        /// </summary>
        /// <value>The outbound international rates.</value>
        [DataMember(Name="outboundInternational", EmitDefaultValue=false)]
        public List<VoiceRateInternational> OutboundInternational { get; set; }
  
        
        /// <summary>
        /// The date of the rate amendment.
        /// </summary>
        /// <value>The date of the rate amendment.</value>
        [DataMember(Name="amendmentDate", EmitDefaultValue=false)]
        public DateTime? AmendmentDate { get; set; }
  
        
        /// <summary>
        /// The effective date of the rate amendment.
        /// </summary>
        /// <value>The effective date of the rate amendment.</value>
        [DataMember(Name="effectiveDate", EmitDefaultValue=false)]
        public DateTime? EffectiveDate { get; set; }
  
        
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
            sb.Append("class VoiceRateUpdate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  InboundTollFree: ").Append(InboundTollFree).Append("\n");
            sb.Append("  Extended: ").Append(Extended).Append("\n");
            sb.Append("  InboundTolled: ").Append(InboundTolled).Append("\n");
            sb.Append("  OutboundLocal: ").Append(OutboundLocal).Append("\n");
            sb.Append("  OutboundIntraState: ").Append(OutboundIntraState).Append("\n");
            sb.Append("  OutboundInterState: ").Append(OutboundInterState).Append("\n");
            sb.Append("  OutboundInternational: ").Append(OutboundInternational).Append("\n");
            sb.Append("  AmendmentDate: ").Append(AmendmentDate).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
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
            return this.Equals(obj as VoiceRateUpdate);
        }

        /// <summary>
        /// Returns true if VoiceRateUpdate instances are equal
        /// </summary>
        /// <param name="obj">Instance of VoiceRateUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoiceRateUpdate other)
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
                    this.InboundTollFree == other.InboundTollFree ||
                    this.InboundTollFree != null &&
                    this.InboundTollFree.Equals(other.InboundTollFree)
                ) && 
                (
                    this.Extended == other.Extended ||
                    this.Extended != null &&
                    this.Extended.SequenceEqual(other.Extended)
                ) && 
                (
                    this.InboundTolled == other.InboundTolled ||
                    this.InboundTolled != null &&
                    this.InboundTolled.Equals(other.InboundTolled)
                ) && 
                (
                    this.OutboundLocal == other.OutboundLocal ||
                    this.OutboundLocal != null &&
                    this.OutboundLocal.Equals(other.OutboundLocal)
                ) && 
                (
                    this.OutboundIntraState == other.OutboundIntraState ||
                    this.OutboundIntraState != null &&
                    this.OutboundIntraState.Equals(other.OutboundIntraState)
                ) && 
                (
                    this.OutboundInterState == other.OutboundInterState ||
                    this.OutboundInterState != null &&
                    this.OutboundInterState.Equals(other.OutboundInterState)
                ) && 
                (
                    this.OutboundInternational == other.OutboundInternational ||
                    this.OutboundInternational != null &&
                    this.OutboundInternational.SequenceEqual(other.OutboundInternational)
                ) && 
                (
                    this.AmendmentDate == other.AmendmentDate ||
                    this.AmendmentDate != null &&
                    this.AmendmentDate.Equals(other.AmendmentDate)
                ) && 
                (
                    this.EffectiveDate == other.EffectiveDate ||
                    this.EffectiveDate != null &&
                    this.EffectiveDate.Equals(other.EffectiveDate)
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
                
                if (this.InboundTollFree != null)
                    hash = hash * 57 + this.InboundTollFree.GetHashCode();
                
                if (this.Extended != null)
                    hash = hash * 57 + this.Extended.GetHashCode();
                
                if (this.InboundTolled != null)
                    hash = hash * 57 + this.InboundTolled.GetHashCode();
                
                if (this.OutboundLocal != null)
                    hash = hash * 57 + this.OutboundLocal.GetHashCode();
                
                if (this.OutboundIntraState != null)
                    hash = hash * 57 + this.OutboundIntraState.GetHashCode();
                
                if (this.OutboundInterState != null)
                    hash = hash * 57 + this.OutboundInterState.GetHashCode();
                
                if (this.OutboundInternational != null)
                    hash = hash * 57 + this.OutboundInternational.GetHashCode();
                
                if (this.AmendmentDate != null)
                    hash = hash * 57 + this.AmendmentDate.GetHashCode();
                
                if (this.EffectiveDate != null)
                    hash = hash * 57 + this.EffectiveDate.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
