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
    public partial class Invoice :  IEquatable<Invoice>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Invoice" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="InvoiceNumber">InvoiceNumber.</param>
        /// <param name="InvoiceDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="DueDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ.</param>
        /// <param name="Amount">Amount.</param>
        /// <param name="Balance">Balance.</param>
        /// <param name="Status">Status.</param>

        public Invoice(string Name = null, string InvoiceNumber = null, DateTime? InvoiceDate = null, DateTime? DueDate = null, string Amount = null, string Balance = null, string Status = null)
        {
            this.Name = Name;
            this.InvoiceNumber = InvoiceNumber;
            this.InvoiceDate = InvoiceDate;
            this.DueDate = DueDate;
            this.Amount = Amount;
            this.Balance = Balance;
            this.Status = Status;
            
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
        /// Gets or Sets InvoiceNumber
        /// </summary>
        [DataMember(Name="invoiceNumber", EmitDefaultValue=false)]
        public string InvoiceNumber { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="invoiceDate", EmitDefaultValue=false)]
        public DateTime? InvoiceDate { get; set; }
    
        /// <summary>
        /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ
        /// </summary>
        /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss.SSSZ</value>
        [DataMember(Name="dueDate", EmitDefaultValue=false)]
        public DateTime? DueDate { get; set; }
    
        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public string Amount { get; set; }
    
        /// <summary>
        /// Gets or Sets Balance
        /// </summary>
        [DataMember(Name="balance", EmitDefaultValue=false)]
        public string Balance { get; set; }
    
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
    
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
            sb.Append("class Invoice {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(obj as Invoice);
        }

        /// <summary>
        /// Returns true if Invoice instances are equal
        /// </summary>
        /// <param name="other">Instance of Invoice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Invoice other)
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
                    this.InvoiceNumber == other.InvoiceNumber ||
                    this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(other.InvoiceNumber)
                ) &&
                (
                    this.InvoiceDate == other.InvoiceDate ||
                    this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(other.InvoiceDate)
                ) &&
                (
                    this.DueDate == other.DueDate ||
                    this.DueDate != null &&
                    this.DueDate.Equals(other.DueDate)
                ) &&
                (
                    this.Amount == other.Amount ||
                    this.Amount != null &&
                    this.Amount.Equals(other.Amount)
                ) &&
                (
                    this.Balance == other.Balance ||
                    this.Balance != null &&
                    this.Balance.Equals(other.Balance)
                ) &&
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
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
                if (this.InvoiceNumber != null)
                    hash = hash * 59 + this.InvoiceNumber.GetHashCode();
                if (this.InvoiceDate != null)
                    hash = hash * 59 + this.InvoiceDate.GetHashCode();
                if (this.DueDate != null)
                    hash = hash * 59 + this.DueDate.GetHashCode();
                if (this.Amount != null)
                    hash = hash * 59 + this.Amount.GetHashCode();
                if (this.Balance != null)
                    hash = hash * 59 + this.Balance.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
