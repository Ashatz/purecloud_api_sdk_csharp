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
    public partial class Account :  IEquatable<Account>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Account" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="OrgLegalName">OrgLegalName.</param>
        /// <param name="BillingAddressLine1">BillingAddressLine1.</param>
        /// <param name="BillingAddressLine2">BillingAddressLine2.</param>
        /// <param name="BillingAddressCity">BillingAddressCity.</param>
        /// <param name="BillingAddressState">BillingAddressState.</param>
        /// <param name="BillingAddressZipCode">BillingAddressZipCode.</param>
        /// <param name="BillingAddressCountry">BillingAddressCountry.</param>
        /// <param name="LegalAddressLine1">LegalAddressLine1.</param>
        /// <param name="LegalAddressLine2">LegalAddressLine2.</param>
        /// <param name="LegalAddressCity">LegalAddressCity.</param>
        /// <param name="LegalAddressState">LegalAddressState.</param>
        /// <param name="LegalAddressZipCode">LegalAddressZipCode.</param>
        /// <param name="LegalAddressCountry">LegalAddressCountry.</param>
        /// <param name="BillingContactFirstName">BillingContactFirstName.</param>
        /// <param name="BillingContactLastName">BillingContactLastName.</param>
        /// <param name="BillingContactEmail">BillingContactEmail.</param>
        /// <param name="BillingContactPhone">BillingContactPhone.</param>
        /// <param name="PurchaseOrderNumber">PurchaseOrderNumber.</param>
        /// <param name="IsTaxExempt">IsTaxExempt (default to false).</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="PaymentTerm">PaymentTerm.</param>
        /// <param name="ContractTerm">ContractTerm.</param>
        /// <param name="AutoRenew">AutoRenew (default to false).</param>
        /// <param name="Enabled">Enabled (default to false).</param>
        /// <param name="MinCommitQuantities">MinCommitQuantities.</param>
        /// <param name="EstimatedQuantities">EstimatedQuantities.</param>
        /// <param name="OneTimeCharges">OneTimeCharges.</param>

        public Account(string Name = null, string OrgLegalName = null, string BillingAddressLine1 = null, string BillingAddressLine2 = null, string BillingAddressCity = null, string BillingAddressState = null, string BillingAddressZipCode = null, string BillingAddressCountry = null, string LegalAddressLine1 = null, string LegalAddressLine2 = null, string LegalAddressCity = null, string LegalAddressState = null, string LegalAddressZipCode = null, string LegalAddressCountry = null, string BillingContactFirstName = null, string BillingContactLastName = null, string BillingContactEmail = null, string BillingContactPhone = null, string PurchaseOrderNumber = null, bool? IsTaxExempt = null, string Currency = null, string PaymentTerm = null, int? ContractTerm = null, bool? AutoRenew = null, bool? Enabled = null, Dictionary<string, int?> MinCommitQuantities = null, Dictionary<string, int?> EstimatedQuantities = null, List<string> OneTimeCharges = null, )
        {
            this.Name = Name;
            this.OrgLegalName = OrgLegalName;
            this.BillingAddressLine1 = BillingAddressLine1;
            this.BillingAddressLine2 = BillingAddressLine2;
            this.BillingAddressCity = BillingAddressCity;
            this.BillingAddressState = BillingAddressState;
            this.BillingAddressZipCode = BillingAddressZipCode;
            this.BillingAddressCountry = BillingAddressCountry;
            this.LegalAddressLine1 = LegalAddressLine1;
            this.LegalAddressLine2 = LegalAddressLine2;
            this.LegalAddressCity = LegalAddressCity;
            this.LegalAddressState = LegalAddressState;
            this.LegalAddressZipCode = LegalAddressZipCode;
            this.LegalAddressCountry = LegalAddressCountry;
            this.BillingContactFirstName = BillingContactFirstName;
            this.BillingContactLastName = BillingContactLastName;
            this.BillingContactEmail = BillingContactEmail;
            this.BillingContactPhone = BillingContactPhone;
            this.PurchaseOrderNumber = PurchaseOrderNumber;
            // use default value if no "IsTaxExempt" provided
            if (IsTaxExempt == null)
            {
                this.IsTaxExempt = false;
            }
            else
            {
                this.IsTaxExempt = IsTaxExempt;
            }
            this.Currency = Currency;
            this.PaymentTerm = PaymentTerm;
            this.ContractTerm = ContractTerm;
            // use default value if no "AutoRenew" provided
            if (AutoRenew == null)
            {
                this.AutoRenew = false;
            }
            else
            {
                this.AutoRenew = AutoRenew;
            }
            // use default value if no "Enabled" provided
            if (Enabled == null)
            {
                this.Enabled = false;
            }
            else
            {
                this.Enabled = Enabled;
            }
            this.MinCommitQuantities = MinCommitQuantities;
            this.EstimatedQuantities = EstimatedQuantities;
            this.OneTimeCharges = OneTimeCharges;
            
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
        /// Gets or Sets OrgLegalName
        /// </summary>
        [DataMember(Name="orgLegalName", EmitDefaultValue=false)]
        public string OrgLegalName { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingAddressLine1
        /// </summary>
        [DataMember(Name="billingAddressLine1", EmitDefaultValue=false)]
        public string BillingAddressLine1 { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingAddressLine2
        /// </summary>
        [DataMember(Name="billingAddressLine2", EmitDefaultValue=false)]
        public string BillingAddressLine2 { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingAddressCity
        /// </summary>
        [DataMember(Name="billingAddressCity", EmitDefaultValue=false)]
        public string BillingAddressCity { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingAddressState
        /// </summary>
        [DataMember(Name="billingAddressState", EmitDefaultValue=false)]
        public string BillingAddressState { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingAddressZipCode
        /// </summary>
        [DataMember(Name="billingAddressZipCode", EmitDefaultValue=false)]
        public string BillingAddressZipCode { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingAddressCountry
        /// </summary>
        [DataMember(Name="billingAddressCountry", EmitDefaultValue=false)]
        public string BillingAddressCountry { get; set; }
    
        /// <summary>
        /// Gets or Sets LegalAddressLine1
        /// </summary>
        [DataMember(Name="legalAddressLine1", EmitDefaultValue=false)]
        public string LegalAddressLine1 { get; set; }
    
        /// <summary>
        /// Gets or Sets LegalAddressLine2
        /// </summary>
        [DataMember(Name="legalAddressLine2", EmitDefaultValue=false)]
        public string LegalAddressLine2 { get; set; }
    
        /// <summary>
        /// Gets or Sets LegalAddressCity
        /// </summary>
        [DataMember(Name="legalAddressCity", EmitDefaultValue=false)]
        public string LegalAddressCity { get; set; }
    
        /// <summary>
        /// Gets or Sets LegalAddressState
        /// </summary>
        [DataMember(Name="legalAddressState", EmitDefaultValue=false)]
        public string LegalAddressState { get; set; }
    
        /// <summary>
        /// Gets or Sets LegalAddressZipCode
        /// </summary>
        [DataMember(Name="legalAddressZipCode", EmitDefaultValue=false)]
        public string LegalAddressZipCode { get; set; }
    
        /// <summary>
        /// Gets or Sets LegalAddressCountry
        /// </summary>
        [DataMember(Name="legalAddressCountry", EmitDefaultValue=false)]
        public string LegalAddressCountry { get; set; }
    
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
        /// Gets or Sets BillingContactEmail
        /// </summary>
        [DataMember(Name="billingContactEmail", EmitDefaultValue=false)]
        public string BillingContactEmail { get; set; }
    
        /// <summary>
        /// Gets or Sets BillingContactPhone
        /// </summary>
        [DataMember(Name="billingContactPhone", EmitDefaultValue=false)]
        public string BillingContactPhone { get; set; }
    
        /// <summary>
        /// Gets or Sets PurchaseOrderNumber
        /// </summary>
        [DataMember(Name="purchaseOrderNumber", EmitDefaultValue=false)]
        public string PurchaseOrderNumber { get; set; }
    
        /// <summary>
        /// Gets or Sets IsTaxExempt
        /// </summary>
        [DataMember(Name="isTaxExempt", EmitDefaultValue=false)]
        public bool? IsTaxExempt { get; set; }
    
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
    
        /// <summary>
        /// Gets or Sets PaymentTerm
        /// </summary>
        [DataMember(Name="paymentTerm", EmitDefaultValue=false)]
        public string PaymentTerm { get; set; }
    
        /// <summary>
        /// Gets or Sets ContractTerm
        /// </summary>
        [DataMember(Name="contractTerm", EmitDefaultValue=false)]
        public int? ContractTerm { get; set; }
    
        /// <summary>
        /// Gets or Sets AutoRenew
        /// </summary>
        [DataMember(Name="autoRenew", EmitDefaultValue=false)]
        public bool? AutoRenew { get; set; }
    
        /// <summary>
        /// Gets or Sets Enabled
        /// </summary>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }
    
        /// <summary>
        /// Gets or Sets MinCommitQuantities
        /// </summary>
        [DataMember(Name="minCommitQuantities", EmitDefaultValue=false)]
        public Dictionary<string, int?> MinCommitQuantities { get; set; }
    
        /// <summary>
        /// Gets or Sets EstimatedQuantities
        /// </summary>
        [DataMember(Name="estimatedQuantities", EmitDefaultValue=false)]
        public Dictionary<string, int?> EstimatedQuantities { get; set; }
    
        /// <summary>
        /// Gets or Sets OneTimeCharges
        /// </summary>
        [DataMember(Name="oneTimeCharges", EmitDefaultValue=false)]
        public List<string> OneTimeCharges { get; set; }
    
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
            sb.Append("class Account {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OrgLegalName: ").Append(OrgLegalName).Append("\n");
            sb.Append("  BillingAddressLine1: ").Append(BillingAddressLine1).Append("\n");
            sb.Append("  BillingAddressLine2: ").Append(BillingAddressLine2).Append("\n");
            sb.Append("  BillingAddressCity: ").Append(BillingAddressCity).Append("\n");
            sb.Append("  BillingAddressState: ").Append(BillingAddressState).Append("\n");
            sb.Append("  BillingAddressZipCode: ").Append(BillingAddressZipCode).Append("\n");
            sb.Append("  BillingAddressCountry: ").Append(BillingAddressCountry).Append("\n");
            sb.Append("  LegalAddressLine1: ").Append(LegalAddressLine1).Append("\n");
            sb.Append("  LegalAddressLine2: ").Append(LegalAddressLine2).Append("\n");
            sb.Append("  LegalAddressCity: ").Append(LegalAddressCity).Append("\n");
            sb.Append("  LegalAddressState: ").Append(LegalAddressState).Append("\n");
            sb.Append("  LegalAddressZipCode: ").Append(LegalAddressZipCode).Append("\n");
            sb.Append("  LegalAddressCountry: ").Append(LegalAddressCountry).Append("\n");
            sb.Append("  BillingContactFirstName: ").Append(BillingContactFirstName).Append("\n");
            sb.Append("  BillingContactLastName: ").Append(BillingContactLastName).Append("\n");
            sb.Append("  BillingContactEmail: ").Append(BillingContactEmail).Append("\n");
            sb.Append("  BillingContactPhone: ").Append(BillingContactPhone).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  IsTaxExempt: ").Append(IsTaxExempt).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PaymentTerm: ").Append(PaymentTerm).Append("\n");
            sb.Append("  ContractTerm: ").Append(ContractTerm).Append("\n");
            sb.Append("  AutoRenew: ").Append(AutoRenew).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  MinCommitQuantities: ").Append(MinCommitQuantities).Append("\n");
            sb.Append("  EstimatedQuantities: ").Append(EstimatedQuantities).Append("\n");
            sb.Append("  OneTimeCharges: ").Append(OneTimeCharges).Append("\n");
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
            return this.Equals(obj as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="other">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account other)
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
                    this.OrgLegalName == other.OrgLegalName ||
                    this.OrgLegalName != null &&
                    this.OrgLegalName.Equals(other.OrgLegalName)
                ) &&
                (
                    this.BillingAddressLine1 == other.BillingAddressLine1 ||
                    this.BillingAddressLine1 != null &&
                    this.BillingAddressLine1.Equals(other.BillingAddressLine1)
                ) &&
                (
                    this.BillingAddressLine2 == other.BillingAddressLine2 ||
                    this.BillingAddressLine2 != null &&
                    this.BillingAddressLine2.Equals(other.BillingAddressLine2)
                ) &&
                (
                    this.BillingAddressCity == other.BillingAddressCity ||
                    this.BillingAddressCity != null &&
                    this.BillingAddressCity.Equals(other.BillingAddressCity)
                ) &&
                (
                    this.BillingAddressState == other.BillingAddressState ||
                    this.BillingAddressState != null &&
                    this.BillingAddressState.Equals(other.BillingAddressState)
                ) &&
                (
                    this.BillingAddressZipCode == other.BillingAddressZipCode ||
                    this.BillingAddressZipCode != null &&
                    this.BillingAddressZipCode.Equals(other.BillingAddressZipCode)
                ) &&
                (
                    this.BillingAddressCountry == other.BillingAddressCountry ||
                    this.BillingAddressCountry != null &&
                    this.BillingAddressCountry.Equals(other.BillingAddressCountry)
                ) &&
                (
                    this.LegalAddressLine1 == other.LegalAddressLine1 ||
                    this.LegalAddressLine1 != null &&
                    this.LegalAddressLine1.Equals(other.LegalAddressLine1)
                ) &&
                (
                    this.LegalAddressLine2 == other.LegalAddressLine2 ||
                    this.LegalAddressLine2 != null &&
                    this.LegalAddressLine2.Equals(other.LegalAddressLine2)
                ) &&
                (
                    this.LegalAddressCity == other.LegalAddressCity ||
                    this.LegalAddressCity != null &&
                    this.LegalAddressCity.Equals(other.LegalAddressCity)
                ) &&
                (
                    this.LegalAddressState == other.LegalAddressState ||
                    this.LegalAddressState != null &&
                    this.LegalAddressState.Equals(other.LegalAddressState)
                ) &&
                (
                    this.LegalAddressZipCode == other.LegalAddressZipCode ||
                    this.LegalAddressZipCode != null &&
                    this.LegalAddressZipCode.Equals(other.LegalAddressZipCode)
                ) &&
                (
                    this.LegalAddressCountry == other.LegalAddressCountry ||
                    this.LegalAddressCountry != null &&
                    this.LegalAddressCountry.Equals(other.LegalAddressCountry)
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
                    this.BillingContactEmail == other.BillingContactEmail ||
                    this.BillingContactEmail != null &&
                    this.BillingContactEmail.Equals(other.BillingContactEmail)
                ) &&
                (
                    this.BillingContactPhone == other.BillingContactPhone ||
                    this.BillingContactPhone != null &&
                    this.BillingContactPhone.Equals(other.BillingContactPhone)
                ) &&
                (
                    this.PurchaseOrderNumber == other.PurchaseOrderNumber ||
                    this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(other.PurchaseOrderNumber)
                ) &&
                (
                    this.IsTaxExempt == other.IsTaxExempt ||
                    this.IsTaxExempt != null &&
                    this.IsTaxExempt.Equals(other.IsTaxExempt)
                ) &&
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) &&
                (
                    this.PaymentTerm == other.PaymentTerm ||
                    this.PaymentTerm != null &&
                    this.PaymentTerm.Equals(other.PaymentTerm)
                ) &&
                (
                    this.ContractTerm == other.ContractTerm ||
                    this.ContractTerm != null &&
                    this.ContractTerm.Equals(other.ContractTerm)
                ) &&
                (
                    this.AutoRenew == other.AutoRenew ||
                    this.AutoRenew != null &&
                    this.AutoRenew.Equals(other.AutoRenew)
                ) &&
                (
                    this.Enabled == other.Enabled ||
                    this.Enabled != null &&
                    this.Enabled.Equals(other.Enabled)
                ) &&
                (
                    this.MinCommitQuantities == other.MinCommitQuantities ||
                    this.MinCommitQuantities != null &&
                    this.MinCommitQuantities.SequenceEqual(other.MinCommitQuantities)
                ) &&
                (
                    this.EstimatedQuantities == other.EstimatedQuantities ||
                    this.EstimatedQuantities != null &&
                    this.EstimatedQuantities.SequenceEqual(other.EstimatedQuantities)
                ) &&
                (
                    this.OneTimeCharges == other.OneTimeCharges ||
                    this.OneTimeCharges != null &&
                    this.OneTimeCharges.SequenceEqual(other.OneTimeCharges)
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
                
                if (this.OrgLegalName != null)
                    hash = hash * 59 + this.OrgLegalName.GetHashCode();
                
                if (this.BillingAddressLine1 != null)
                    hash = hash * 59 + this.BillingAddressLine1.GetHashCode();
                
                if (this.BillingAddressLine2 != null)
                    hash = hash * 59 + this.BillingAddressLine2.GetHashCode();
                
                if (this.BillingAddressCity != null)
                    hash = hash * 59 + this.BillingAddressCity.GetHashCode();
                
                if (this.BillingAddressState != null)
                    hash = hash * 59 + this.BillingAddressState.GetHashCode();
                
                if (this.BillingAddressZipCode != null)
                    hash = hash * 59 + this.BillingAddressZipCode.GetHashCode();
                
                if (this.BillingAddressCountry != null)
                    hash = hash * 59 + this.BillingAddressCountry.GetHashCode();
                
                if (this.LegalAddressLine1 != null)
                    hash = hash * 59 + this.LegalAddressLine1.GetHashCode();
                
                if (this.LegalAddressLine2 != null)
                    hash = hash * 59 + this.LegalAddressLine2.GetHashCode();
                
                if (this.LegalAddressCity != null)
                    hash = hash * 59 + this.LegalAddressCity.GetHashCode();
                
                if (this.LegalAddressState != null)
                    hash = hash * 59 + this.LegalAddressState.GetHashCode();
                
                if (this.LegalAddressZipCode != null)
                    hash = hash * 59 + this.LegalAddressZipCode.GetHashCode();
                
                if (this.LegalAddressCountry != null)
                    hash = hash * 59 + this.LegalAddressCountry.GetHashCode();
                
                if (this.BillingContactFirstName != null)
                    hash = hash * 59 + this.BillingContactFirstName.GetHashCode();
                
                if (this.BillingContactLastName != null)
                    hash = hash * 59 + this.BillingContactLastName.GetHashCode();
                
                if (this.BillingContactEmail != null)
                    hash = hash * 59 + this.BillingContactEmail.GetHashCode();
                
                if (this.BillingContactPhone != null)
                    hash = hash * 59 + this.BillingContactPhone.GetHashCode();
                
                if (this.PurchaseOrderNumber != null)
                    hash = hash * 59 + this.PurchaseOrderNumber.GetHashCode();
                
                if (this.IsTaxExempt != null)
                    hash = hash * 59 + this.IsTaxExempt.GetHashCode();
                
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                
                if (this.PaymentTerm != null)
                    hash = hash * 59 + this.PaymentTerm.GetHashCode();
                
                if (this.ContractTerm != null)
                    hash = hash * 59 + this.ContractTerm.GetHashCode();
                
                if (this.AutoRenew != null)
                    hash = hash * 59 + this.AutoRenew.GetHashCode();
                
                if (this.Enabled != null)
                    hash = hash * 59 + this.Enabled.GetHashCode();
                
                if (this.MinCommitQuantities != null)
                    hash = hash * 59 + this.MinCommitQuantities.GetHashCode();
                
                if (this.EstimatedQuantities != null)
                    hash = hash * 59 + this.EstimatedQuantities.GetHashCode();
                
                if (this.OneTimeCharges != null)
                    hash = hash * 59 + this.OneTimeCharges.GetHashCode();
                
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                
                return hash;
            }
        }

    }
}
