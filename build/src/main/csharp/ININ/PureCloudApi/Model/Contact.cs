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
    public partial class Contact :  IEquatable<Contact>
    { 
<<<<<<< HEAD
        
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" />class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="ContactListId">ContactListId.</param>
        /// <param name="Data">Data.</param>
        /// <param name="CallRecords">CallRecords.</param>
        /// <param name="Callable">Callable (default to false).</param>
        /// <param name="PhoneNumberStatus">PhoneNumberStatus.</param>

        public Contact(string Name = null, string ContactListId = null, Dictionary<string, Object> Data = null, Dictionary<string, CallRecord> CallRecords = null, bool? Callable = null, Dictionary<string, PhoneNumberStatus> PhoneNumberStatus = null)
        {
            this.Name = Name;
            this.ContactListId = ContactListId;
            this.Data = Data;
            this.CallRecords = CallRecords;
            // use default value if no "Callable" provided
            if (Callable == null)
            {
                this.Callable = false;
            }
            else
            {
                this.Callable = Callable;
            }
            this.PhoneNumberStatus = PhoneNumberStatus;
=======

        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum MediaTypeEnum {
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
            
            [EnumMember(Value = "PHONE")]
            Phone,
            
            [EnumMember(Value = "EMAIL")]
            Email,
            
            [EnumMember(Value = "SMS")]
            Sms
        }

<<<<<<< HEAD
    
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
    
=======

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="contactListId", EmitDefaultValue=false)]
        public string ContactListId { get; set; }
    
=======
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum {
            
            [EnumMember(Value = "PRIMARY")]
            Primary,
            
            [EnumMember(Value = "WORK")]
            Work,
            
            [EnumMember(Value = "HOME")]
            Home,
            
            [EnumMember(Value = "MOBILE")]
            Mobile,
            
            [EnumMember(Value = "MAIN")]
            Main
        }

        
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
        /// <summary>
        /// Gets or Sets MediaType
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="data", EmitDefaultValue=false)]
        public Dictionary<string, Object> Data { get; set; }
=======
        [DataMember(Name="mediaType", EmitDefaultValue=false)]
        public MediaTypeEnum? MediaType { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="callRecords", EmitDefaultValue=false)]
        public Dictionary<string, CallRecord> CallRecords { get; set; }
=======
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" />class.
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="callable", EmitDefaultValue=false)]
        public bool? Callable { get; set; }
=======
        /// <param name="Address">Email address or phone number for this contact type.</param>
        /// <param name="MediaType">MediaType.</param>
        /// <param name="Type">Type.</param>

        public Contact(string Address = null, MediaTypeEnum? MediaType = null, TypeEnum? Type = null)
        {
            this.Address = Address;
            this.MediaType = MediaType;
            this.Type = Type;
            
        }

>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Email address or phone number for this contact type
        /// </summary>
<<<<<<< HEAD
        [DataMember(Name="phoneNumberStatus", EmitDefaultValue=false)]
        public Dictionary<string, PhoneNumberStatus> PhoneNumberStatus { get; set; }
=======
        /// <value>Email address or phone number for this contact type</value>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public string Address { get; set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Formatted version of the address property
        /// </summary>
<<<<<<< HEAD
        /// <value>The URI for this object</value>
        [DataMember(Name="selfUri", EmitDefaultValue=false)]
        public string SelfUri { get; private set; }
=======
        /// <value>Formatted version of the address property</value>
        [DataMember(Name="display", EmitDefaultValue=false)]
        public string Display { get; private set; }
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
    
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contact {\n");
<<<<<<< HEAD
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContactListId: ").Append(ContactListId).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  CallRecords: ").Append(CallRecords).Append("\n");
            sb.Append("  Callable: ").Append(Callable).Append("\n");
            sb.Append("  PhoneNumberStatus: ").Append(PhoneNumberStatus).Append("\n");
            sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
=======
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
            sb.Append("  MediaType: ").Append(MediaType).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
            return this.Equals(obj as Contact);
        }

        /// <summary>
        /// Returns true if Contact instances are equal
        /// </summary>
        /// <param name="other">Instance of Contact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contact other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
<<<<<<< HEAD
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
                    this.ContactListId == other.ContactListId ||
                    this.ContactListId != null &&
                    this.ContactListId.Equals(other.ContactListId)
                ) &&
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(other.Data)
                ) &&
                (
                    this.CallRecords == other.CallRecords ||
                    this.CallRecords != null &&
                    this.CallRecords.SequenceEqual(other.CallRecords)
                ) &&
                (
                    this.Callable == other.Callable ||
                    this.Callable != null &&
                    this.Callable.Equals(other.Callable)
                ) &&
                (
                    this.PhoneNumberStatus == other.PhoneNumberStatus ||
                    this.PhoneNumberStatus != null &&
                    this.PhoneNumberStatus.SequenceEqual(other.PhoneNumberStatus)
                ) &&
                (
                    this.SelfUri == other.SelfUri ||
                    this.SelfUri != null &&
                    this.SelfUri.Equals(other.SelfUri)
=======
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) &&
                (
                    this.Display == other.Display ||
                    this.Display != null &&
                    this.Display.Equals(other.Display)
                ) &&
                (
                    this.MediaType == other.MediaType ||
                    this.MediaType != null &&
                    this.MediaType.Equals(other.MediaType)
                ) &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
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
<<<<<<< HEAD
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.ContactListId != null)
                    hash = hash * 59 + this.ContactListId.GetHashCode();
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                if (this.CallRecords != null)
                    hash = hash * 59 + this.CallRecords.GetHashCode();
                if (this.Callable != null)
                    hash = hash * 59 + this.Callable.GetHashCode();
                if (this.PhoneNumberStatus != null)
                    hash = hash * 59 + this.PhoneNumberStatus.GetHashCode();
                if (this.SelfUri != null)
                    hash = hash * 59 + this.SelfUri.GetHashCode();
=======
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Display != null)
                    hash = hash * 59 + this.Display.GetHashCode();
                if (this.MediaType != null)
                    hash = hash * 59 + this.MediaType.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
>>>>>>> ffdc7a4f6e60c898e481eba1ab2f0f8fe0c1c548
                return hash;
            }
        }

    }
}
