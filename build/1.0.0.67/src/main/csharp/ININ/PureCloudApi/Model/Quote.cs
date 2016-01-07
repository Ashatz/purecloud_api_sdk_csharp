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
    public class Quote :  IEquatable<Quote>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quote" /> class.
        /// </summary>
        public Quote()
        {
            this.IsSubmitted = false;
            this.IsPending = false;
            this.IsFrozen = false;
            this.IncludeVoiceCharges = false;
            
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
        /// Gets or Sets PurchaseOrder
        /// </summary>
        [DataMember(Name="purchaseOrder", EmitDefaultValue=false)]
        public string PurchaseOrder { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IsSubmitted
        /// </summary>
        [DataMember(Name="isSubmitted", EmitDefaultValue=false)]
        public bool? IsSubmitted { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IsPending
        /// </summary>
        [DataMember(Name="isPending", EmitDefaultValue=false)]
        public bool? IsPending { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IsFrozen
        /// </summary>
        [DataMember(Name="isFrozen", EmitDefaultValue=false)]
        public bool? IsFrozen { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BillingContactEmail
        /// </summary>
        [DataMember(Name="billingContactEmail", EmitDefaultValue=false)]
        public string BillingContactEmail { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BillingContactFirstName
        /// </summary>
        [DataMember(Name="billingContactFirstName", EmitDefaultValue=false)]
        public string BillingContactFirstName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BillingContactLastName
        /// </summary>
        [DataMember(Name="billingContactLastName", EmitDefaultValue=false)]
        public string BillingContactLastName { get; set; }
  
        
        /// <summary>
        /// Gets or Sets BillingContactPhone
        /// </summary>
        [DataMember(Name="billingContactPhone", EmitDefaultValue=false)]
        public string BillingContactPhone { get; set; }
  
        
        /// <summary>
        /// Gets or Sets IncludeVoiceCharges
        /// </summary>
        [DataMember(Name="includeVoiceCharges", EmitDefaultValue=false)]
        public bool? IncludeVoiceCharges { get; set; }
  
        
        /// <summary>
        /// Gets or Sets Charges
        /// </summary>
        [DataMember(Name="charges", EmitDefaultValue=false)]
        public List<QuoteCharge> Charges { get; set; }
  
        
        /// <summary>
        /// Gets or Sets EdgeControlModel
        /// </summary>
        [DataMember(Name="edgeControlModel", EmitDefaultValue=false)]
        public string EdgeControlModel { get; set; }
  
        
        /// <summary>
        /// Gets or Sets ReferralCodes
        /// </summary>
        [DataMember(Name="referralCodes", EmitDefaultValue=false)]
        public List<string> ReferralCodes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DiscountCodes
        /// </summary>
        [DataMember(Name="discountCodes", EmitDefaultValue=false)]
        public List<string> DiscountCodes { get; set; }
  
        
        /// <summary>
        /// Gets or Sets SalesPartnerCode
        /// </summary>
        [DataMember(Name="salesPartnerCode", EmitDefaultValue=false)]
        public string SalesPartnerCode { get; set; }
  
        
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
            sb.Append("class Quote {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PurchaseOrder: ").Append(PurchaseOrder).Append("\n");
            sb.Append("  IsSubmitted: ").Append(IsSubmitted).Append("\n");
            sb.Append("  IsPending: ").Append(IsPending).Append("\n");
            sb.Append("  IsFrozen: ").Append(IsFrozen).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  BillingContactEmail: ").Append(BillingContactEmail).Append("\n");
            sb.Append("  BillingContactFirstName: ").Append(BillingContactFirstName).Append("\n");
            sb.Append("  BillingContactLastName: ").Append(BillingContactLastName).Append("\n");
            sb.Append("  BillingContactPhone: ").Append(BillingContactPhone).Append("\n");
            sb.Append("  IncludeVoiceCharges: ").Append(IncludeVoiceCharges).Append("\n");
            sb.Append("  Charges: ").Append(Charges).Append("\n");
            sb.Append("  EdgeControlModel: ").Append(EdgeControlModel).Append("\n");
            sb.Append("  ReferralCodes: ").Append(ReferralCodes).Append("\n");
            sb.Append("  DiscountCodes: ").Append(DiscountCodes).Append("\n");
            sb.Append("  SalesPartnerCode: ").Append(SalesPartnerCode).Append("\n");
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
            return this.Equals(obj as Quote);
        }

        /// <summary>
        /// Returns true if Quote instances are equal
        /// </summary>
        /// <param name="obj">Instance of Quote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Quote other)
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
                    this.PurchaseOrder == other.PurchaseOrder ||
                    this.PurchaseOrder != null &&
                    this.PurchaseOrder.Equals(other.PurchaseOrder)
                ) && 
                (
                    this.IsSubmitted == other.IsSubmitted ||
                    this.IsSubmitted != null &&
                    this.IsSubmitted.Equals(other.IsSubmitted)
                ) && 
                (
                    this.IsPending == other.IsPending ||
                    this.IsPending != null &&
                    this.IsPending.Equals(other.IsPending)
                ) && 
                (
                    this.IsFrozen == other.IsFrozen ||
                    this.IsFrozen != null &&
                    this.IsFrozen.Equals(other.IsFrozen)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.BillingContactEmail == other.BillingContactEmail ||
                    this.BillingContactEmail != null &&
                    this.BillingContactEmail.Equals(other.BillingContactEmail)
                ) && 
                (
                    this.BillingContactFirstName == other.BillingContactFirstName ||
                    this.BillingContactFirstName != null &&
                    this.BillingContactFirstName.Equals(other.BillingContactFirstName)
                ) && 
                (
                    this.BillingContactLastName == other.BillingContactLastName ||
                    this.BillingContactLastName != null &&
                    this.BillingContactLastName.Equals(other.BillingContactLastName)
                ) && 
                (
                    this.BillingContactPhone == other.BillingContactPhone ||
                    this.BillingContactPhone != null &&
                    this.BillingContactPhone.Equals(other.BillingContactPhone)
                ) && 
                (
                    this.IncludeVoiceCharges == other.IncludeVoiceCharges ||
                    this.IncludeVoiceCharges != null &&
                    this.IncludeVoiceCharges.Equals(other.IncludeVoiceCharges)
                ) && 
                (
                    this.Charges == other.Charges ||
                    this.Charges != null &&
                    this.Charges.SequenceEqual(other.Charges)
                ) && 
                (
                    this.EdgeControlModel == other.EdgeControlModel ||
                    this.EdgeControlModel != null &&
                    this.EdgeControlModel.Equals(other.EdgeControlModel)
                ) && 
                (
                    this.ReferralCodes == other.ReferralCodes ||
                    this.ReferralCodes != null &&
                    this.ReferralCodes.SequenceEqual(other.ReferralCodes)
                ) && 
                (
                    this.DiscountCodes == other.DiscountCodes ||
                    this.DiscountCodes != null &&
                    this.DiscountCodes.SequenceEqual(other.DiscountCodes)
                ) && 
                (
                    this.SalesPartnerCode == other.SalesPartnerCode ||
                    this.SalesPartnerCode != null &&
                    this.SalesPartnerCode.Equals(other.SalesPartnerCode)
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
                
                if (this.PurchaseOrder != null)
                    hash = hash * 57 + this.PurchaseOrder.GetHashCode();
                
                if (this.IsSubmitted != null)
                    hash = hash * 57 + this.IsSubmitted.GetHashCode();
                
                if (this.IsPending != null)
                    hash = hash * 57 + this.IsPending.GetHashCode();
                
                if (this.IsFrozen != null)
                    hash = hash * 57 + this.IsFrozen.GetHashCode();
                
                if (this.Currency != null)
                    hash = hash * 57 + this.Currency.GetHashCode();
                
                if (this.BillingContactEmail != null)
                    hash = hash * 57 + this.BillingContactEmail.GetHashCode();
                
                if (this.BillingContactFirstName != null)
                    hash = hash * 57 + this.BillingContactFirstName.GetHashCode();
                
                if (this.BillingContactLastName != null)
                    hash = hash * 57 + this.BillingContactLastName.GetHashCode();
                
                if (this.BillingContactPhone != null)
                    hash = hash * 57 + this.BillingContactPhone.GetHashCode();
                
                if (this.IncludeVoiceCharges != null)
                    hash = hash * 57 + this.IncludeVoiceCharges.GetHashCode();
                
                if (this.Charges != null)
                    hash = hash * 57 + this.Charges.GetHashCode();
                
                if (this.EdgeControlModel != null)
                    hash = hash * 57 + this.EdgeControlModel.GetHashCode();
                
                if (this.ReferralCodes != null)
                    hash = hash * 57 + this.ReferralCodes.GetHashCode();
                
                if (this.DiscountCodes != null)
                    hash = hash * 57 + this.DiscountCodes.GetHashCode();
                
                if (this.SalesPartnerCode != null)
                    hash = hash * 57 + this.SalesPartnerCode.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 57 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }


}
