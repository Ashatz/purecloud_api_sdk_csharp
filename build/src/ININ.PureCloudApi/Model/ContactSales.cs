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
    /// ContactSales
    /// </summary>
    [DataContract]
    public partial class ContactSales :  IEquatable<ContactSales>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactSales" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactSales() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactSales" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Email">Email (required).</param>
        /// <param name="FirstName">First Name (required).</param>
        /// <param name="LastName">Last Name (required).</param>
        /// <param name="ContactPhone">Phone (required).</param>
        /// <param name="Country">Country (required).</param>
        /// <param name="Title">Title (required).</param>
        /// <param name="Message">Message (required).</param>
        /// <param name="Language">Language (required).</param>
        /// <param name="ProductName">Product Name (required).</param>
        /// <param name="QuoteId">Quote Id (required).</param>
        public ContactSales(string Name = null, string Email = null, string FirstName = null, string LastName = null, string ContactPhone = null, string Country = null, string Title = null, string Message = null, string Language = null, string ProductName = null, string QuoteId = null)
        {
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for ContactSales and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for ContactSales and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for ContactSales and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "ContactPhone" is required (not null)
            if (ContactPhone == null)
            {
                throw new InvalidDataException("ContactPhone is a required property for ContactSales and cannot be null");
            }
            else
            {
                this.ContactPhone = ContactPhone;
            }
            // to ensure "Country" is required (not null)
            if (Country == null)
            {
                throw new InvalidDataException("Country is a required property for ContactSales and cannot be null");
            }
            else
            {
                this.Country = Country;
            }
            // to ensure "Title" is required (not null)
            if (Title == null)
            {
                throw new InvalidDataException("Title is a required property for ContactSales and cannot be null");
            }
            else
            {
                this.Title = Title;
            }
            // to ensure "Message" is required (not null)
            if (Message == null)
            {
                throw new InvalidDataException("Message is a required property for ContactSales and cannot be null");
            }
            else
            {
                this.Message = Message;
            }
            // to ensure "Language" is required (not null)
            if (Language == null)
            {
                throw new InvalidDataException("Language is a required property for ContactSales and cannot be null");
            }
            else
            {
                this.Language = Language;
            }
            // to ensure "ProductName" is required (not null)
            if (ProductName == null)
            {
                throw new InvalidDataException("ProductName is a required property for ContactSales and cannot be null");
            }
            else
            {
                this.ProductName = ProductName;
            }
            // to ensure "QuoteId" is required (not null)
            if (QuoteId == null)
            {
                throw new InvalidDataException("QuoteId is a required property for ContactSales and cannot be null");
            }
            else
            {
                this.QuoteId = QuoteId;
            }
            this.Name = Name;
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
        /// Email
        /// </summary>
        /// <value>Email</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// First Name
        /// </summary>
        /// <value>First Name</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
        /// <summary>
        /// Last Name
        /// </summary>
        /// <value>Last Name</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
        /// <summary>
        /// Phone
        /// </summary>
        /// <value>Phone</value>
        [DataMember(Name="contactPhone", EmitDefaultValue=false)]
        public string ContactPhone { get; set; }
        /// <summary>
        /// Country
        /// </summary>
        /// <value>Country</value>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
        /// <summary>
        /// Title
        /// </summary>
        /// <value>Title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
        /// <summary>
        /// Message
        /// </summary>
        /// <value>Message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
        /// <summary>
        /// Language
        /// </summary>
        /// <value>Language</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }
        /// <summary>
        /// Product Name
        /// </summary>
        /// <value>Product Name</value>
        [DataMember(Name="productName", EmitDefaultValue=false)]
        public string ProductName { get; set; }
        /// <summary>
        /// Quote Id
        /// </summary>
        /// <value>Quote Id</value>
        [DataMember(Name="quoteId", EmitDefaultValue=false)]
        public string QuoteId { get; set; }
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
            sb.Append("class ContactSales {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  ContactPhone: ").Append(ContactPhone).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  QuoteId: ").Append(QuoteId).Append("\n");
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
            return this.Equals(obj as ContactSales);
        }

        /// <summary>
        /// Returns true if ContactSales instances are equal
        /// </summary>
        /// <param name="other">Instance of ContactSales to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactSales other)
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
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) &&
                (
                    this.FirstName == other.FirstName ||
                    this.FirstName != null &&
                    this.FirstName.Equals(other.FirstName)
                ) &&
                (
                    this.LastName == other.LastName ||
                    this.LastName != null &&
                    this.LastName.Equals(other.LastName)
                ) &&
                (
                    this.ContactPhone == other.ContactPhone ||
                    this.ContactPhone != null &&
                    this.ContactPhone.Equals(other.ContactPhone)
                ) &&
                (
                    this.Country == other.Country ||
                    this.Country != null &&
                    this.Country.Equals(other.Country)
                ) &&
                (
                    this.Title == other.Title ||
                    this.Title != null &&
                    this.Title.Equals(other.Title)
                ) &&
                (
                    this.Message == other.Message ||
                    this.Message != null &&
                    this.Message.Equals(other.Message)
                ) &&
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) &&
                (
                    this.ProductName == other.ProductName ||
                    this.ProductName != null &&
                    this.ProductName.Equals(other.ProductName)
                ) &&
                (
                    this.QuoteId == other.QuoteId ||
                    this.QuoteId != null &&
                    this.QuoteId.Equals(other.QuoteId)
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
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.FirstName != null)
                    hash = hash * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hash = hash * 59 + this.LastName.GetHashCode();
                if (this.ContactPhone != null)
                    hash = hash * 59 + this.ContactPhone.GetHashCode();
                if (this.Country != null)
                    hash = hash * 59 + this.Country.GetHashCode();
                if (this.Title != null)
                    hash = hash * 59 + this.Title.GetHashCode();
                if (this.Message != null)
                    hash = hash * 59 + this.Message.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.ProductName != null)
                    hash = hash * 59 + this.ProductName.GetHashCode();
                if (this.QuoteId != null)
                    hash = hash * 59 + this.QuoteId.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }
    }

}
