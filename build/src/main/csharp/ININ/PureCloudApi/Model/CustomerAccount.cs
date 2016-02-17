using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace ININ.PureCloudApi.Model
{

    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class CustomerAccount :  IEquatable<CustomerAccount>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerAccount" /> class.
        /// </summary>
        public CustomerAccount()
        {
            this.IsFrozen = false;
            this.IsTaxExempt = false;
            
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
        /// Indicates whether the account is currently frozen for review.
        /// </summary>
        /// <value>Indicates whether the account is currently frozen for review.</value>
        [DataMember(Name="isFrozen", EmitDefaultValue=false)]
        public bool? IsFrozen { get; set; }
  
        
        /// <summary>
        /// The organization legal name.
        /// </summary>
        /// <value>The organization legal name.</value>
        [DataMember(Name="orgLegalName", EmitDefaultValue=false)]
        public string OrgLegalName { get; set; }
  
        
        /// <summary>
        /// The organization phone number.
        /// </summary>
        /// <value>The organization phone number.</value>
        [DataMember(Name="orgPhone", EmitDefaultValue=false)]
        public string OrgPhone { get; set; }
  
        
        /// <summary>
        /// Indicates whether the account is tax exempt.
        /// </summary>
        /// <value>Indicates whether the account is tax exempt.</value>
        [DataMember(Name="isTaxExempt", EmitDefaultValue=false)]
        public bool? IsTaxExempt { get; set; }
  
        
        /// <summary>
        /// The account billing address.
        /// </summary>
        /// <value>The account billing address.</value>
        [DataMember(Name="billingAddress", EmitDefaultValue=false)]
        public Address BillingAddress { get; set; }
  
        
        /// <summary>
        /// The account currency.
        /// </summary>
        /// <value>The account currency.</value>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
  
        
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
            sb.Append("class CustomerAccount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsFrozen: ").Append(IsFrozen).Append("\n");
            sb.Append("  OrgLegalName: ").Append(OrgLegalName).Append("\n");
            sb.Append("  OrgPhone: ").Append(OrgPhone).Append("\n");
            sb.Append("  IsTaxExempt: ").Append(IsTaxExempt).Append("\n");
            sb.Append("  BillingAddress: ").Append(BillingAddress).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(obj as CustomerAccount);
        }

        /// <summary>
        /// Returns true if CustomerAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of CustomerAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerAccount other)
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
                    this.IsFrozen == other.IsFrozen ||
                    this.IsFrozen != null &&
                    this.IsFrozen.Equals(other.IsFrozen)
                ) && 
                (
                    this.OrgLegalName == other.OrgLegalName ||
                    this.OrgLegalName != null &&
                    this.OrgLegalName.Equals(other.OrgLegalName)
                ) && 
                (
                    this.OrgPhone == other.OrgPhone ||
                    this.OrgPhone != null &&
                    this.OrgPhone.Equals(other.OrgPhone)
                ) && 
                (
                    this.IsTaxExempt == other.IsTaxExempt ||
                    this.IsTaxExempt != null &&
                    this.IsTaxExempt.Equals(other.IsTaxExempt)
                ) && 
                (
                    this.BillingAddress == other.BillingAddress ||
                    this.BillingAddress != null &&
                    this.BillingAddress.Equals(other.BillingAddress)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
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
                
                if (this.IsFrozen != null)
                    hash = hash * 59 + this.IsFrozen.GetHashCode();
                
                if (this.OrgLegalName != null)
                    hash = hash * 59 + this.OrgLegalName.GetHashCode();
                
                if (this.OrgPhone != null)
                    hash = hash * 59 + this.OrgPhone.GetHashCode();
                
                if (this.IsTaxExempt != null)
                    hash = hash * 59 + this.IsTaxExempt.GetHashCode();
                
                if (this.BillingAddress != null)
                    hash = hash * 59 + this.BillingAddress.GetHashCode();
                
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
