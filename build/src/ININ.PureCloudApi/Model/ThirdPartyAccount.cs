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
    /// ThirdPartyAccount
    /// </summary>
    [DataContract]
    public partial class ThirdPartyAccount :  IEquatable<ThirdPartyAccount>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyAccount" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="AccountNumber">AccountNumber.</param>
        /// <param name="Currency">Currency.</param>
        /// <param name="Invoices">Invoices.</param>
        /// <param name="Subscriptions">Subscriptions.</param>
        public ThirdPartyAccount(string Name = null, string AccountNumber = null, string Currency = null, List<Invoice> Invoices = null, List<ThirdPartySubscription> Subscriptions = null)
        {
            this.Name = Name;
            this.AccountNumber = AccountNumber;
            this.Currency = Currency;
            this.Invoices = Invoices;
            this.Subscriptions = Subscriptions;
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
        /// Gets or Sets AccountNumber
        /// </summary>
        [DataMember(Name="accountNumber", EmitDefaultValue=false)]
        public string AccountNumber { get; set; }
        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name="currency", EmitDefaultValue=false)]
        public string Currency { get; set; }
        /// <summary>
        /// Gets or Sets Invoices
        /// </summary>
        [DataMember(Name="invoices", EmitDefaultValue=false)]
        public List<Invoice> Invoices { get; set; }
        /// <summary>
        /// Gets or Sets Subscriptions
        /// </summary>
        [DataMember(Name="subscriptions", EmitDefaultValue=false)]
        public List<ThirdPartySubscription> Subscriptions { get; set; }
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
            sb.Append("class ThirdPartyAccount {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Invoices: ").Append(Invoices).Append("\n");
            sb.Append("  Subscriptions: ").Append(Subscriptions).Append("\n");
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
            return this.Equals(obj as ThirdPartyAccount);
        }

        /// <summary>
        /// Returns true if ThirdPartyAccount instances are equal
        /// </summary>
        /// <param name="other">Instance of ThirdPartyAccount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThirdPartyAccount other)
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
                    this.AccountNumber == other.AccountNumber ||
                    this.AccountNumber != null &&
                    this.AccountNumber.Equals(other.AccountNumber)
                ) &&
                (
                    this.Currency == other.Currency ||
                    this.Currency != null &&
                    this.Currency.Equals(other.Currency)
                ) &&
                (
                    this.Invoices == other.Invoices ||
                    this.Invoices != null &&
                    this.Invoices.SequenceEqual(other.Invoices)
                ) &&
                (
                    this.Subscriptions == other.Subscriptions ||
                    this.Subscriptions != null &&
                    this.Subscriptions.SequenceEqual(other.Subscriptions)
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
                if (this.AccountNumber != null)
                    hash = hash * 59 + this.AccountNumber.GetHashCode();
                if (this.Currency != null)
                    hash = hash * 59 + this.Currency.GetHashCode();
                if (this.Invoices != null)
                    hash = hash * 59 + this.Invoices.GetHashCode();
                if (this.Subscriptions != null)
                    hash = hash * 59 + this.Subscriptions.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
