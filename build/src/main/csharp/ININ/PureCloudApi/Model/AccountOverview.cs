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
    public partial class AccountOverview :  IEquatable<AccountOverview>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountOverview" /> class.
        /// </summary>
        public AccountOverview()
        {
            this.IsSuperUser = false;
            this.HasAccountNumber = false;
            
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
        /// Gets or Sets IsSuperUser
        /// </summary>
        [DataMember(Name="isSuperUser", EmitDefaultValue=false)]
        public bool? IsSuperUser { get; set; }
  
        
        /// <summary>
        /// Gets or Sets HasAccountNumber
        /// </summary>
        [DataMember(Name="hasAccountNumber", EmitDefaultValue=false)]
        public bool? HasAccountNumber { get; set; }
  
        
        /// <summary>
        /// Gets or Sets UsageCharges
        /// </summary>
        [DataMember(Name="usageCharges", EmitDefaultValue=false)]
        public List<Charge> UsageCharges { get; set; }
  
        
        /// <summary>
        /// Gets or Sets DomesticChargesTotal
        /// </summary>
        [DataMember(Name="domesticChargesTotal", EmitDefaultValue=false)]
        public int? DomesticChargesTotal { get; set; }
  
        
        /// <summary>
        /// Gets or Sets InternationalChargesTotal
        /// </summary>
        [DataMember(Name="internationalChargesTotal", EmitDefaultValue=false)]
        public int? InternationalChargesTotal { get; set; }
  
        
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
            sb.Append("class AccountOverview {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsSuperUser: ").Append(IsSuperUser).Append("\n");
            sb.Append("  HasAccountNumber: ").Append(HasAccountNumber).Append("\n");
            sb.Append("  UsageCharges: ").Append(UsageCharges).Append("\n");
            sb.Append("  DomesticChargesTotal: ").Append(DomesticChargesTotal).Append("\n");
            sb.Append("  InternationalChargesTotal: ").Append(InternationalChargesTotal).Append("\n");
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
            return this.Equals(obj as AccountOverview);
        }

        /// <summary>
        /// Returns true if AccountOverview instances are equal
        /// </summary>
        /// <param name="other">Instance of AccountOverview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountOverview other)
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
                    this.IsSuperUser == other.IsSuperUser ||
                    this.IsSuperUser != null &&
                    this.IsSuperUser.Equals(other.IsSuperUser)
                ) && 
                (
                    this.HasAccountNumber == other.HasAccountNumber ||
                    this.HasAccountNumber != null &&
                    this.HasAccountNumber.Equals(other.HasAccountNumber)
                ) && 
                (
                    this.UsageCharges == other.UsageCharges ||
                    this.UsageCharges != null &&
                    this.UsageCharges.SequenceEqual(other.UsageCharges)
                ) && 
                (
                    this.DomesticChargesTotal == other.DomesticChargesTotal ||
                    this.DomesticChargesTotal != null &&
                    this.DomesticChargesTotal.Equals(other.DomesticChargesTotal)
                ) && 
                (
                    this.InternationalChargesTotal == other.InternationalChargesTotal ||
                    this.InternationalChargesTotal != null &&
                    this.InternationalChargesTotal.Equals(other.InternationalChargesTotal)
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
                
                if (this.IsSuperUser != null)
                    hash = hash * 59 + this.IsSuperUser.GetHashCode();
                
                if (this.HasAccountNumber != null)
                    hash = hash * 59 + this.HasAccountNumber.GetHashCode();
                
                if (this.UsageCharges != null)
                    hash = hash * 59 + this.UsageCharges.GetHashCode();
                
                if (this.DomesticChargesTotal != null)
                    hash = hash * 59 + this.DomesticChargesTotal.GetHashCode();
                
                if (this.InternationalChargesTotal != null)
                    hash = hash * 59 + this.InternationalChargesTotal.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
