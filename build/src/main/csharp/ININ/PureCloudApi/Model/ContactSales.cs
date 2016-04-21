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
    public partial class ContactSales :  IEquatable<ContactSales>
    { 
        
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactSales" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Email">Email.</param>
        /// <param name="FirstName">FirstName.</param>
        /// <param name="LastName">LastName.</param>
        /// <param name="ContactPhone">ContactPhone.</param>
        /// <param name="Country">Country.</param>
        /// <param name="Title">Title.</param>
        /// <param name="Message">Message.</param>
        /// <param name="Language">Language.</param>
        /// <param name="ProductName">ProductName.</param>
        /// <param name="QuoteId">QuoteId.</param>
<<<<<<< HEAD
        /// <param name="Industry">Industry.</param>
        /// <param name="EstimatedUsers">EstimatedUsers.</param>

        public ContactSales(string Name = null, string Email = null, string FirstName = null, string LastName = null, string ContactPhone = null, string Country = null, string Title = null, string Message = null, string Language = null, string ProductName = null, string QuoteId = null, string Industry = null, string EstimatedUsers = null)
=======

        public ContactSales(string Name = null, string Email = null, string FirstName = null, string LastName = null, string ContactPhone = null, string Country = null, string Title = null, string Message = null, string Language = null, string ProductName = null, string QuoteId = null)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        {
            this.Name = Name;
            this.Email = Email;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.ContactPhone = ContactPhone;
            this.Country = Country;
            this.Title = Title;
            this.Message = Message;
            this.Language = Language;
            this.ProductName = ProductName;
            this.QuoteId = QuoteId;
<<<<<<< HEAD
            this.Industry = Industry;
            this.EstimatedUsers = EstimatedUsers;
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
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
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
    
        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }
    
        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }
    
        /// <summary>
        /// Gets or Sets ContactPhone
        /// </summary>
        [DataMember(Name="contactPhone", EmitDefaultValue=false)]
        public string ContactPhone { get; set; }
    
        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }
    
        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }
    
        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }
    
        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }
    
        /// <summary>
        /// Gets or Sets ProductName
        /// </summary>
        [DataMember(Name="productName", EmitDefaultValue=false)]
        public string ProductName { get; set; }
    
        /// <summary>
        /// Gets or Sets QuoteId
        /// </summary>
        [DataMember(Name="quoteId", EmitDefaultValue=false)]
        public string QuoteId { get; set; }
    
<<<<<<< HEAD
        /// <summary>
        /// Gets or Sets Industry
        /// </summary>
        [DataMember(Name="industry", EmitDefaultValue=false)]
        public string Industry { get; set; }
    
        /// <summary>
        /// Gets or Sets EstimatedUsers
        /// </summary>
        [DataMember(Name="estimatedUsers", EmitDefaultValue=false)]
        public string EstimatedUsers { get; set; }
    
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                (
                    this.Industry == other.Industry ||
                    this.Industry != null &&
                    this.Industry.Equals(other.Industry)
                ) &&
                (
                    this.EstimatedUsers == other.EstimatedUsers ||
                    this.EstimatedUsers != null &&
                    this.EstimatedUsers.Equals(other.EstimatedUsers)
                ) &&
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                if (this.Industry != null)
                    hash = hash * 59 + this.Industry.GetHashCode();
                if (this.EstimatedUsers != null)
                    hash = hash * 59 + this.EstimatedUsers.GetHashCode();
=======
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
                return hash;
            }
        }

    }
}
