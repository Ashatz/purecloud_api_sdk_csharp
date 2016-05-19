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
    /// Quote
    /// </summary>
    [DataContract]
    public partial class Quote :  IEquatable<Quote>
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            
            /// <summary>
            /// Enum NewSubscription for "NEW_SUBSCRIPTION"
            /// </summary>
            [EnumMember(Value = "NEW_SUBSCRIPTION")]
            NewSubscription,
            
            /// <summary>
            /// Enum Amendment for "AMENDMENT"
            /// </summary>
            [EnumMember(Value = "AMENDMENT")]
            Amendment
        }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            
            /// <summary>
            /// Enum InProgress for "IN_PROGRESS"
            /// </summary>
            [EnumMember(Value = "IN_PROGRESS")]
            InProgress,
            
            /// <summary>
            /// Enum Submitted for "SUBMITTED"
            /// </summary>
            [EnumMember(Value = "SUBMITTED")]
            Submitted,
            
            /// <summary>
            /// Enum Frozen for "FROZEN"
            /// </summary>
            [EnumMember(Value = "FROZEN")]
            Frozen
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Quote" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="PurchaseOrder">PurchaseOrder.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Status">Status.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="CreatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="LastUpdatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="BillingContactEmail">BillingContactEmail.</param>
        /// <param name="BillingContactFirstName">BillingContactFirstName.</param>
        /// <param name="BillingContactLastName">BillingContactLastName.</param>
        /// <param name="BillingContactPhone">BillingContactPhone.</param>
        /// <param name="IncludeVoiceCharges">IncludeVoiceCharges (default to false).</param>
        /// <param name="Charges">Charges.</param>
        /// <param name="EdgeControlModel">EdgeControlModel.</param>
        /// <param name="ReferralCodes">ReferralCodes.</param>
        /// <param name="DiscountCodes">DiscountCodes.</param>
        /// <param name="SalesPartnerCode">SalesPartnerCode.</param>
        /// <param name="IsAnnualPrepay">IsAnnualPrepay (default to false).</param>
        public Quote(, string Name = null, string PurchaseOrder = null, TypeEnum? Type = null, StatusEnum? Status = null, string Currency = null, DateTime? CreatedDate = null, DateTime? LastUpdatedDate = null, string BillingContactEmail = null, string BillingContactFirstName = null, string BillingContactLastName = null, string BillingContactPhone = null, bool? IncludeVoiceCharges = null, List<QuoteCharge> Charges = null, string EdgeControlModel = null, List<string> ReferralCodes = null, List<string> DiscountCodes = null, string SalesPartnerCode = null, bool? IsAnnualPrepay = null)
        {
            this.Name = Name;
            this.PurchaseOrder = PurchaseOrder;
            this.Type = Type;
            this.Status = Status;
            this.Currency = Currency;
            this.CreatedDate = CreatedDate;
            this.LastUpdatedDate = LastUpdatedDate;
            this.BillingContactEmail = BillingContactEmail;
            this.BillingContactFirstName = BillingContactFirstName;
            this.BillingContactLastName = BillingContactLastName;
            this.BillingContactPhone = BillingContactPhone;
            // use default value if no "IncludeVoiceCharges" provided
            if (IncludeVoiceCharges == null)
            {
                this.IncludeVoiceCharges = false;
            }
            else
            {
                this.IncludeVoiceCharges = IncludeVoiceCharges;
            }
            this.Charges = Charges;
            this.EdgeControlModel = EdgeControlModel;
            this.ReferralCodes = ReferralCodes;
            this.DiscountCodes = DiscountCodes;
            this.SalesPartnerCode = SalesPartnerCode;
            // use default value if no "IsAnnualPrepay" provided
            if (IsAnnualPrepay == null)
            {
                this.IsAnnualPrepay = false;
            }
            else
            {
                this.IsAnnualPrepay = IsAnnualPrepay;
            }
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
        /// Gets or Sets PurchaseOrder
        /// </summary>
        [DataMember(Name="purchaseOrder", EmitDefaultValue=false)]
        public string PurchaseOrder { get; set; }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="createdDate", EmitDefaultValue=false)]
        public DateTime? CreatedDate { get; set; }
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="lastUpdatedDate", EmitDefaultValue=false)]
        public DateTime? LastUpdatedDate { get; set; }
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
        /// Gets or Sets IsAnnualPrepay
        /// </summary>
        [DataMember(Name="isAnnualPrepay", EmitDefaultValue=false)]
        public bool? IsAnnualPrepay { get; set; }
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
            sb.Append("class Quote {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PurchaseOrder: ").Append(PurchaseOrder).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
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
            sb.Append("  IsAnnualPrepay: ").Append(IsAnnualPrepay).Append("\n");
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
        /// <param name="other">Instance of Quote to be compared</param>
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) && 
                (
                    this.CreatedDate == other.CreatedDate ||
                    this.CreatedDate != null &&
                    this.CreatedDate.Equals(other.CreatedDate)
                ) && 
                (
                    this.LastUpdatedDate == other.LastUpdatedDate ||
                    this.LastUpdatedDate != null &&
                    this.LastUpdatedDate.Equals(other.LastUpdatedDate)
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
                    this.IsAnnualPrepay == other.IsAnnualPrepay ||
                    this.IsAnnualPrepay != null &&
                    this.IsAnnualPrepay.Equals(other.IsAnnualPrepay)
                )
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
                if (this.PurchaseOrder != null)
                    hash = hash * 59 + this.PurchaseOrder.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.CreatedDate != null)
                    hash = hash * 59 + this.CreatedDate.GetHashCode();
                if (this.LastUpdatedDate != null)
                    hash = hash * 59 + this.LastUpdatedDate.GetHashCode();
                if (this.BillingContactEmail != null)
                    hash = hash * 59 + this.BillingContactEmail.GetHashCode();
                if (this.BillingContactFirstName != null)
                    hash = hash * 59 + this.BillingContactFirstName.GetHashCode();
                if (this.BillingContactLastName != null)
                    hash = hash * 59 + this.BillingContactLastName.GetHashCode();
                if (this.BillingContactPhone != null)
                    hash = hash * 59 + this.BillingContactPhone.GetHashCode();
                if (this.IncludeVoiceCharges != null)
                    hash = hash * 59 + this.IncludeVoiceCharges.GetHashCode();
                if (this.Charges != null)
                    hash = hash * 59 + this.Charges.GetHashCode();
                if (this.EdgeControlModel != null)
                    hash = hash * 59 + this.EdgeControlModel.GetHashCode();
                if (this.ReferralCodes != null)
                    hash = hash * 59 + this.ReferralCodes.GetHashCode();
                if (this.DiscountCodes != null)
                    hash = hash * 59 + this.DiscountCodes.GetHashCode();
                if (this.SalesPartnerCode != null)
                    hash = hash * 59 + this.SalesPartnerCode.GetHashCode();
                if (this.IsAnnualPrepay != null)
                    hash = hash * 59 + this.IsAnnualPrepay.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
