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
    public class VoiceRate :  IEquatable<VoiceRate>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoiceRate" /> class.
        /// </summary>
        public VoiceRate()
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
            sb.Append("class VoiceRate {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  AmendmentId: ").Append(AmendmentId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  EffectiveDate: ").Append(EffectiveDate).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  DurationMinimumSeconds: ").Append(DurationMinimumSeconds).Append("\n");
            sb.Append("  DurationIncrementSeconds: ").Append(DurationIncrementSeconds).Append("\n");
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
            return this.Equals(obj as VoiceRate);
        }

        /// <summary>
        /// Returns true if VoiceRate instances are equal
        /// </summary>
        /// <param name="obj">Instance of VoiceRate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoiceRate other)
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
                
                if (this.Rate != null)
                    hash = hash * 57 + this.Rate.GetHashCode();
                
                if (this.DurationMinimumSeconds != null)
                    hash = hash * 57 + this.DurationMinimumSeconds.GetHashCode();
                
                if (this.DurationIncrementSeconds != null)
                    hash = hash * 57 + this.DurationIncrementSeconds.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
